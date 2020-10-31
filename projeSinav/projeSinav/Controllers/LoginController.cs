using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using projeSinav.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace projeSinav.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        

        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(Kullanici p)
        {
            
            var bilgiler = c.Kullanicilar.FirstOrDefault(x => x.ad == p.ad && x.sifre == p.sifre);

            if (bilgiler != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.ad)
                };

                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("sinavOl", "Login");
            }

            else
            {
                ViewBag.LoginError = "Hatalı Kullanıcı Adı veya Şifre";
            }


            return View();
        }

        public ActionResult sinavOl()
        {

            return View();
        }
        










    }
}
