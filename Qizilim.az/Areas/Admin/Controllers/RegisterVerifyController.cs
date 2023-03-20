using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Qizilim.az.AppCode.Modules.RegisterVerify;
using Qizilim.az.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Qizilim.az.Areas.Admin.Controllers
{   [Area("Admin")]
    [Authorize(Roles = "Superadmin,Admin")]
    public class RegisterVerifyController : Controller
    {
        readonly IMediator mediator;
        readonly QizilimDbContext db;
        public RegisterVerifyController(IMediator mediator, QizilimDbContext db)
        {
            this.mediator = mediator;
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {

            var data = await mediator.Send(new UsersAllQuery());
            return View(data);
            
        }

        public async Task<IActionResult> Accept(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await db.Users.Where(u => u.Id == id).FirstOrDefaultAsync();

            shop.Status = true;
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Premium(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await db.Users.Where(u => u.Id == id).FirstOrDefaultAsync();

            shop.isPremium = true;
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Silver(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await db.Users.Where(u => u.Id == id).FirstOrDefaultAsync();

            shop.isPremium = false;
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Normal(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await db.Users.Where(u => u.Id == id).FirstOrDefaultAsync();

            shop.isPremium = null;
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Reject(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shop = await db.Users.Where(u => u.Id == id).FirstOrDefaultAsync();

            shop.Status = false;
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
    
}
