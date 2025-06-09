using BlazorBootstrap;
using E_Book_site.Data;
using E_Book_site.Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace Components.Main.Pages
{
    public class MySignInModel : PageModel
    {
        AppDbContext Db;

        public Users Users { get; set; } = new();

        public MySignInModel(AppDbContext db)
        {
            Db = db;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            var ValidUser = Db.Users.Where(e => e.Email == Users.Email && e.Password == Users.Password).FirstOrDefault();
            if (ValidUser is null)
            {
                return Redirect("/MySignIn");
                //messages.Add(CreateToastMessage(ToastType.Danger));
            }

            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, ValidUser.UserName),
            new Claim(ClaimTypes.Email, ValidUser.Email),
            new Claim(ClaimTypes.Role, ValidUser.Role)
        };

            var Identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var Principal = new ClaimsPrincipal(Identity);

            await HttpContext.SignInAsync(Principal);
            return Redirect("/Admin");


        }
    }
}
