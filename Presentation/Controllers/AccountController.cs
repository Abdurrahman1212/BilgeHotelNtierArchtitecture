using BussinessLogicLayer.DtoClasses;
using Common_Test.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using MVC.Models;
using Presentation.Models;

namespace Presentation.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole<int>> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager; 

        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel appUser)
        {
            
            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = appUser.UserName,
                    Email = appUser.Email,
                    Address = appUser.Address,
                    UpdatedComputerName = System.Environment.MachineName,

                };

                //Veritabanı kayıt işlemi
                var result = await _userManager.CreateAsync(user, appUser.ConfirmPassword);

                if (result.Succeeded)
                {
                    #region RolKontrolIslemleri

                    IdentityRole<int> role = new IdentityRole<int>();
                    role.Name = "Admin";

                    IdentityResult roleResult = await _roleManager.CreateAsync(role);

                    await _userManager.AddToRoleAsync(user, "Admin");

                    //IdentityRole<int> appRole = await _roleManager.FindByNameAsync("Member");
                    //if (appRole == null) await _roleManager.CreateAsync(new() { Name = "Member" });
                    //await _userManager.AddToRoleAsync(user, "Member");


                    IdentityRole<int> Approle = new IdentityRole<int>();
                    role.Name = "Employee";

                    IdentityResult ApproleResult = await _roleManager.CreateAsync(role);

                    await _userManager.AddToRoleAsync(user, "Employee");

                    string message = $"Hesabınız olusturulmustur...Üyeliginiz onaylamak icin lüfen http://localhost:5104/Account/ConfirmEmail?specId={user.ActivationCode}&id={user.Id} linkine  tıklayınız";


                    MailSender.Send(appUser.Email, body: message);
                    TempData["Message"] = "Lütfen hesabınızı onaylamak icin emailinizi kontrol ediniz";

                    #endregion


                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(appUser);
                }
            }
            else
            {
                return View(appUser);
            }

        }


        public async Task<IActionResult> ConfirmEmail(Guid specId, int id)
        {
            User user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                TempData["Message"] = "Kullanıcı bulunamadı";
                return RedirectToAction("Index");
            }
            else if (user.ActivationCode == specId)
            {
                user.EmailConfirmed = true;
                await _userManager.UpdateAsync(user);
                TempData["message"] = "Hesabınız basarıyla onaylandı";
                return RedirectToAction("Login");
            }

            return RedirectToAction("Index");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel appUser)
                {
            if (ModelState.IsValid)
            {
                User user = await _userManager.FindByNameAsync(appUser.UserName );

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, appUser.Password, appUser.RememberMe, false);

                    if (result.Succeeded)
                    {
                        IList<string> roles = await _userManager.GetRolesAsync(user);


                        if (roles.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Home", new { Area = "Dashboard" });
                        }

                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(appUser);
           
        }

        public async Task<IActionResult> Logout()
            {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> DeleteUser(int userId)
        {
            if (userId <= 0)
            {
                return BadRequest("Geçersiz Kullanıcı ID'si.");
            }
            User user = await _userManager.FindByIdAsync(userId.ToString());

            // Rezervasyon bulunamadıysa hata döndür
            if (user == null)
            {
                return NotFound("Kullanıcı bulunamadı veya bu işlem için yetkiniz yok.");
            }
            await _userManager.DeleteAsync(user);

            return Json("ok");
        }

        //[HttpPost, ActionName("DeleteUserDetails")]
        ////[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteUserDetailsConfirmed(int id)
        //{
        //    var user = await _context.Users.FindAsync(id);
        //    if (user != null)
        //    {
        //        _context.Users.Remove(user);
        //        await _context.SaveChangesAsync();
        //    }

        //    return RedirectToAction(nameof(Index));
        //}
        [HttpPost]
        public async Task<IActionResult> EditUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound();
            }

            var userDto = new UserDTO
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                Address = user.Address,
                UpdatedDate = user.UpdatedDate,
                MasterId = user.MasterId,
                UpdatedComputerName=user.UpdatedComputerName,
                PhoneNumber=user.PhoneNumber
            };

            return PartialView("~/Views/Account/Partial/_EditUser.cshtml",userDto);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUserDetails(int id, [Bind("Id,UserName,Email,Address,UpdatedDate,MasterId,UpdatedComputerName,PhoneNumber")] UserDTO userDto)
        {
            if (id != userDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.FindByIdAsync(id.ToString());
                    if (user == null)
                    {
                        return NotFound();
                    }

                    user.UserName = userDto.UserName;
                    user.Email = userDto.Email;
                    user.Address = userDto.Address;
                    user.UpdatedDate = DateTime.Now;
                    user.PhoneNumber = userDto.PhoneNumber;
                    user.MasterId = userDto.MasterId;
                    user.UpdatedComputerName = userDto.UpdatedComputerName;
                    await _userManager.UpdateAsync(user);
                    
                }
                catch (Exception ex)
                {
                    return Json(ex.Message);
                }
            }
            return RedirectToAction("UserDetails","Home");
        }
    }
}

