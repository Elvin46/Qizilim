using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Qizilim.az.AppCode.Extensions;
using Qizilim.az.Models.DataContext;
using Qizilim.az.Models.Entities.Membreship;
using Qizilim.az.Models.FormModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qizilim.az.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly IMediator mediator;
        private readonly QizilimDbContext db;
        private readonly IActionContextAccessor ctx;
        private readonly SignInManager<QizilimUser> signInManager;
        private readonly UserManager<QizilimUser> userManager;
        public RegisterController(IMediator mediator,
            SignInManager<QizilimUser> signInManager,
            UserManager<QizilimUser> userManager,
            IActionContextAccessor ctx,
            QizilimDbContext db)
        {
            this.mediator = mediator;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.db = db;
            this.ctx = ctx;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser(string name, string surname, string username, string email, 
            string phoneNumber, string password, string passwordAgain)
        {

            //if (model?.file == null)
            //{
            //    ctx.AddModelError("ProfileImg", "Fayl Sechilmeyib!");
            //}


            if (ctx.ModelIsValid())
            {
                //string fileExtension = Path.GetExtension(model.file.FileName);

                //string name = $"userStudent-{Guid.NewGuid()}{fileExtension}";
                //string physicalPath = Path.Combine(env.ContentRootPath, "wwwroot", "photouploads", "images", name);

                //using (FileStream fs = new FileStream(physicalPath, FileMode.Create, FileAccess.Write))
                //{
                //    await model.file.CopyToAsync(fs);
                //}




                var user = new QizilimUser
                {
                    //ProfileImg = name,
                    Name = name,
                    Surname = surname,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    UserName = username,
                    EmailConfirmed = true,
                    catdirilma = false,
                    PhoneNumberConfirmed = true,
                    Status = true,
                    Wallet = null
                };



                var result = await userManager.CreateAsync(user, password);

                await userManager.AddToRoleAsync(user, "User");

            }

            return Json(new { status = 200 });
        }


        [HttpPost]
        public async Task<IActionResult> RegisterShop(string name, string surname, string username, string email,
               string phoneNumber, string password, string passwordAgain, string selectedLocation, string shopName, string shopPhone)
        {

            //if (model?.file == null)
            //{
            //    ctx.AddModelError("ProfileImg", "Fayl Sechilmeyib!");
            //}


            if (ctx.ModelIsValid())
            {
                //string fileExtension = Path.GetExtension(model.file.FileName);

                //string name = $"userStudent-{Guid.NewGuid()}{fileExtension}";
                //string physicalPath = Path.Combine(env.ContentRootPath, "wwwroot", "photouploads", "images", name);

                //using (FileStream fs = new FileStream(physicalPath, FileMode.Create, FileAccess.Write))
                //{
                //    await model.file.CopyToAsync(fs);
                //}




                var shop = new QizilimUser
                {
                    //ProfileImg = name,
                    Name = name,
                    Surname = surname,
                    Email = email,
                    PhoneNumber = phoneNumber,
                    UserName = username,
                    shopLocation = selectedLocation,
                    shopName = shopName,
                    shopNumber = shopPhone,
                    catdirilma = false,
                    PhoneNumberConfirmed = true,
                    Wallet = 0
                };



                var result = await userManager.CreateAsync(shop, password);

                await userManager.AddToRoleAsync(shop, "Shop");



            }

            return Json(new { status = 200 });
        }
    }
}
