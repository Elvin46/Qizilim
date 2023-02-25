using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Qizilim.az.AppCode.Extensions;
using Qizilim.az.AppCode.Modules;
using Qizilim.az.AppCode.Modules.AccountModule;
using Qizilim.az.Models.DataContext;
using Qizilim.az.Models.Entities.Membreship;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Qizilim.az.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMediator mediator;
        private readonly QizilimDbContext db;
        private readonly IWebHostEnvironment env;
        private readonly IActionContextAccessor ctx;
        private readonly SignInManager<QizilimUser> signInManager;
        private readonly UserManager<QizilimUser> userManager;
        public AccountController(IMediator mediator,
            IActionContextAccessor ctx,
            SignInManager<QizilimUser> signInManager,
            UserManager<QizilimUser> userManager,
            IWebHostEnvironment env,
            QizilimDbContext db)
        {
            this.mediator = mediator;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.db = db;
            this.ctx = ctx;
            this.env = env;
        }

        [AllowAnonymous]
        [Route("/signin.html")]
        public async Task<IActionResult> Signin()
        {
            ViewBag.Center = await db.Centers.Where(c => c.DeletedById == null).ToListAsync();
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [Route("/signin.html")]
        public async Task<IActionResult> Signin(SigninCommand command)
        {
            var centers = await db.Centers.Where(c => c.DeletedById == null).ToListAsync();
            ViewBag.Center = centers;
            var response = await mediator.Send(command);

            if (!ModelState.IsValid)
            {
                return View(command);
            }

            var user = await db.Users.Where(u => u.UserName == command.Username).FirstOrDefaultAsync();

            if (user.Status == null)
            {
                return RedirectToAction("verifyRegister", "Account");
            }
            else if (user.Status == false)
            {
                return RedirectToAction("rejectedRegister", "Account");
            }

            if (User.IsInRole("Superadmin") || User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "admin");
            }

            if (User.IsInRole("Shop"))
            {
                return RedirectToAction("Index", "shop");
            }

            var redirectUrl = Request.Query["ReturnUrl"];

            if (!string.IsNullOrWhiteSpace(redirectUrl))
            {
                return Redirect(redirectUrl);
            }
            return RedirectToAction("Index", "homepage");
        }


        [AllowAnonymous]
        [Route("/signout.html")]
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Homepage");
        }



        public async Task<IActionResult> myStore()
        {
            var userAbout = await userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.User = userAbout;


            if (userAbout.Status == null)
            {
                return RedirectToAction("verifyRegister", "account");
            }
            else if (userAbout.Status == false)
            {
                return RedirectToAction("rejectedRegister", "account");
            }

            ViewBag.ProductEyar = db.ProductEyar.Where(u => u.ProductId == userAbout.Id).ToList();
            ViewBag.Eyar = db.Eyars.Where(u => u.DeletedById == null);

            ViewBag.Shops = db.Users.Where(u => u.shopName != null).ToList();

            ViewBag.LikedProducts = db.LikedProducts.Where(lp => lp.UserId == userAbout.Id);

            var model = db.Products
                .Where(p => p.DeletedById == null && p.CreatedById == userAbout.Id).ToList();
            return View(model);
        }


        public async Task<IActionResult> editTheAccount(AccountSingleQuery query)
        {
            var userAbout = await userManager.FindByNameAsync(User.Identity.Name);
            var centers = await db.Centers.Where(c => c.DeletedById == null).ToListAsync();
            ViewBag.User = userAbout;
            ViewBag.Centers = centers;


            if (userAbout.Status == null)
            {
                return RedirectToAction("verifyRegister", "account");
            }
            else if (userAbout.Status == false)
            {
                return RedirectToAction("rejectedRegister", "account");
            }

            var entity = await mediator.Send(query);
            if (entity == null)
            {
                return NotFound();
            }

            var command = new AccountEditCommand();
            command.ProfileImg = entity.ProfileImg;
            command.Email = entity.Email;
            command.shopName = entity.shopName;
            command.shopLocation = entity.shopLocation;
            command.shopNumber = entity.shopNumber;
            command.aboutShop = entity.aboutShop;
            command.whatsappNumber = entity.whatsappNumber;
            command.instagramLink = entity.instagramLink;
            command.tiktokLink = entity.tiktokLink;
            command.catdirilma = entity.catdirilma;
            return View(command);
        }

        [HttpPost]
        public async Task<IActionResult> editTheAccount(int id, AccountEditCommand command)
        {
            var userAbout = await userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.User = userAbout;


            if (userAbout.Status == null)
            {
                return RedirectToAction("verifyRegister", "account");
            }
            else if (userAbout.Status == false)
            {
                return RedirectToAction("rejectedRegister", "account");
            }


            if (id != command.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var response = await mediator.Send(command);

                return RedirectToAction(nameof(Index));
            }
            return View(command);
        }




        public async Task<IActionResult> addingProduct()
        {


            var userAbout = await userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.User = userAbout;


            if (userAbout.Status == null)
            {
                return RedirectToAction("verifyRegister", "account");
            }
            else if (userAbout.Status == false)
            {
                return RedirectToAction("rejectedRegister", "account");
            }

            ViewBag.Color = new SelectList(db.Colors, "Id", "Name");
            ViewBag.Category = await db.Kateqoriya.Where(i => i.DeletedById == null).ToListAsync();
            ViewBag.Eyar = new SelectList(db.Eyars, "Id", "EyarOlcusu");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> addingProduct(ProductCreateCommand command)
        {


            var userAbout = await userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.User = userAbout;

            if (userAbout.Status == null)
            {
                return RedirectToAction("verifyRegister", "account");
            }
            else if (userAbout.Status == false)
            {
                return RedirectToAction("rejectedRegister", "account");
            }

            if (ModelState.IsValid)
            {
                var response = await mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Color = new SelectList(db.Colors, "Id", "Name");
            ViewBag.Category = await db.Kateqoriya.Where(i => i.DeletedById == null).ToListAsync();
            ViewBag.Eyar = new SelectList(db.Eyars, "Id", "EyarOlcusu");
            return RedirectToAction("myStore", "account");
        }



        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (User.Identity.Name != null)
            {
                var userAbout = await userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = userAbout;

                if (userAbout.Status == null)
                {
                    return RedirectToAction("verifyRegister", "account");
                }
                else if (userAbout.Status == false)
                {
                    return RedirectToAction("rejectedRegister", "account");
                }
            }
            if (id == null)
            {
                return NotFound();
            }

            var centers = await db.Centers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (centers == null)
            {
                return NotFound();
            }

            return View(centers);
        }


        [HttpPost]
        public async Task<IActionResult> DeleteProduct(ProductRemoveCommand command)
        {
            if (User.Identity.Name != null)
            {
                var userAbout = await userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = userAbout;

                if (userAbout.Status == null)
                {
                    return RedirectToAction("verifyRegister", "account");
                }
                else if (userAbout.Status == false)
                {
                    return RedirectToAction("rejectedRegister", "account");
                }
            }
            var response = await mediator.Send(command);

            return Json(response);
        }



        public async Task<IActionResult> PremiumProduct(int? productId, int dayPremium)
        {
            var userAbout = await userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.User = userAbout;
            

                if (userAbout.Status == null)
                {
                    return RedirectToAction("verifyRegister", "account");
                }
                else if (userAbout.Status == false)
                {
                    return RedirectToAction("rejectedRegister", "account");
                }

            var products = await db.Products.FirstOrDefaultAsync(lp => lp.Id == productId);

            if (products.PremiumProduct)
            {
                return Json(new { status = 100 });
            }
            else if(userAbout.Wallet > dayPremium)
            {
                products.PremiumProduct = true;
                products.PremiumStartDate = DateTime.UtcNow.AddHours(4);
                products.PremiumEndDate = DateTime.UtcNow.AddDays(dayPremium).AddHours(4);
                userAbout.Wallet = userAbout.Wallet - dayPremium;
            }
            else if(userAbout.Wallet < dayPremium)
            {
                return Json(new { status = 300 });
            }

            await db.SaveChangesAsync();

            return Json(new { status = 200 });
        }




        public async Task<IActionResult> FirstProduct(int? productId)
        {
            var userAbout = await userManager.FindByNameAsync(User.Identity.Name);

            ViewBag.User = userAbout; 
                

                if (userAbout.Status == null)
                {
                    return RedirectToAction("verifyRegister", "account");
                }
                else if (userAbout.Status == false)
                {
                    return RedirectToAction("rejectedRegister", "account");
                }



            var products = await db.Products.FirstOrDefaultAsync(lp => lp.Id == productId);

            if (products.IreliCekilmisProduct)
            {
                return Json(new { status = 100 });
            }
            else if(userAbout.Wallet >= 1)
            {
                products.IreliCekilmisProduct = true;
                products.IreliStartDate = DateTime.UtcNow.AddHours(4);
                products.IreliEndDate = DateTime.UtcNow.AddDays(1).AddHours(4);
                userAbout.Wallet = userAbout.Wallet - 1;
            }
            else if (userAbout.Wallet < 1)
            {
                return Json(new { status = 300 });
            }

            await db.SaveChangesAsync();

            return Json(new { status = 200 });
        }

        [AllowAnonymous]
        public async Task<IActionResult> verifyRegister()
        {
            if (User.Identity.Name != null)
            {
                var userAbout = await userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = userAbout;

                if (userAbout.Status == true)
                {
                    return RedirectToAction("index", "homepage");
                }
            }
            return View();
        }

        public async Task<IActionResult> rejectedRegister()
        {
            if (User.Identity.Name != null)
            {
                var userAbout = await userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.User = userAbout;

                
            }
            return View();
        }


        public async Task<IActionResult> addWallet(int countWallet)
        {
            var userAbout = await userManager.FindByNameAsync(User.Identity.Name);

            userAbout.Wallet += countWallet;
            await db.SaveChangesAsync();

            return Json(new { status = 200 });
        }
    }
}
