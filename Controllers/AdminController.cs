//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using System.Threading.Tasks;
//using System.Linq;
//using F1_Web_App.Models;

//namespace F1_Web_App.Controllers
//{
//    [Authorize(Roles = "Administrator")]
//    public class AdminController : Controller
//    {
//        private readonly RoleManager<IdentityRole> _roleManager;
//        private readonly UserManager<IdentityUser> _userManager;

//        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
//        {
//            _roleManager = roleManager;
//            _userManager = userManager;
//        }

//        // Действие за показване на списък с роли
//        public IActionResult Index()
//        {
//            var roles = _roleManager.Roles.ToList();
//            return View(roles);
//        }

//        // Действие за създаване на нова роля
//        public IActionResult CreateRole()
//        {
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> CreateRole(string roleName)
//        {
//            if (!string.IsNullOrEmpty(roleName))
//            {
//                var roleExist = await _roleManager.RoleExistsAsync(roleName);
//                if (!roleExist)
//                {
//                    await _roleManager.CreateAsync(new IdentityRole(roleName));
//                }
//            }
//            return RedirectToAction("Index");
//        }

//        // Действие за показване на списък с потребители
//        public IActionResult Users()
//        {
//            var users = _userManager.Users.ToList();
//            return View(users);
//        }

//        // Действие за редактиране на роли на потребител
//        public async Task<IActionResult> EditUserRoles(string userId)
//        {
//            var user = await _userManager.FindByIdAsync(userId);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            var userRoles = await _userManager.GetRolesAsync(user);
//            var allRoles = _roleManager.Roles.ToList();

//            var model = new UserEditRolesViewModel
//            {
//                UserId = user.Id,
//                UserName = user.UserName,
//                UserRoles = userRoles,
//                AllRoles = allRoles
//            };

//            return View(model);
//        }

//        [HttpPost]
//        public async Task<IActionResult> EditUserRoles(UserEditRolesViewModel model)
//        {
//            var user = await _userManager.FindByIdAsync(model.UserId);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            var userRoles = await _userManager.GetRolesAsync(user);
//            var selectedRoles = model.UserRoles ?? new List<string>();

//            var result = await _userManager.AddToRolesAsync(user, selectedRoles.Except(userRoles));
//            if (!result.Succeeded)
//            {
//                ModelState.AddModelError("", "Failed to add roles");
//                return View(model);
//            }

//            result = await _userManager.RemoveFromRolesAsync(user, userRoles.Except(selectedRoles));
//            if (!result.Succeeded)
//            {
//                ModelState.AddModelError("", "Failed to remove roles");
//                return View(model);
//            }

//            return RedirectToAction("Users");
//        }

//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<IActionResult> DeleteUser(string userId)
//        {
//            var user = await _userManager.FindByIdAsync(userId);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            var result = await _userManager.DeleteAsync(user);
//            if (!result.Succeeded)
//            {
//                // Handle error
//                ModelState.AddModelError("", "Failed to delete user");
//            }

//            return RedirectToAction("Users");
//        }
//    }
//}
