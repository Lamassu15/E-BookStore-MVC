using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Web.Data.Access.Repository.IRepository;
using Web.Models;
using Web.Models.ViewModels;
using Web.Ultility;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace E_BookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IUnitOfWork _unitOfWork;
        public UserController(UserManager<IdentityUser> userManager, IUnitOfWork unitOfWork, RoleManager<IdentityRole> roleManager)
        {
            _unitOfWork = unitOfWork;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<ApplicationUser> objUserList = _unitOfWork.ApplicationUser.GetAll().ToList();

            foreach (var user in objUserList)
            {

                user.Role = _userManager.GetRolesAsync(user).GetAwaiter().GetResult().FirstOrDefault();
            }

            return Json(new { data = objUserList });
        }


        [HttpPost]
        public IActionResult LockUnlock([FromBody] string id)
        {

            var objFromDb = _unitOfWork.ApplicationUser.Get(u => u.Id == id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while Locking/Unlocking" });
            }

            if (objFromDb.LockoutEnd != null && objFromDb.LockoutEnd > DateTime.Now)
            {
                //user is currently locked and we need to unlock them
                objFromDb.LockoutEnd = DateTime.Now;
            }
            else
            {
                objFromDb.LockoutEnd = DateTime.Now.AddYears(1000);
            }
            _unitOfWork.ApplicationUser.Update(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Operation Successful!" });
        }

        public IActionResult RoleManagment(string userId)
        {

            RoleManagmentVM RoleVM = new RoleManagmentVM()
            {
                ApplicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == userId),
                RoleList = _roleManager.Roles.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Name
                })
            };

            RoleVM.ApplicationUser.Role = _userManager.GetRolesAsync(_unitOfWork.ApplicationUser.Get(u => u.Id == userId))
                    .GetAwaiter().GetResult().FirstOrDefault();
            return View(RoleVM);
        }

        [HttpPost]
        public IActionResult RoleManagment(RoleManagmentVM roleManagmentVM)
        {

            string oldRole = _userManager.GetRolesAsync(_unitOfWork.ApplicationUser.Get(u => u.Id == roleManagmentVM.ApplicationUser.Id))
                    .GetAwaiter().GetResult().FirstOrDefault();

            ApplicationUser applicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == roleManagmentVM.ApplicationUser.Id);


            if (!(roleManagmentVM.ApplicationUser.Role == oldRole))
            {
                _unitOfWork.ApplicationUser.Update(applicationUser);
                _unitOfWork.Save();

                _userManager.RemoveFromRoleAsync(applicationUser, oldRole).GetAwaiter().GetResult();
                _userManager.AddToRoleAsync(applicationUser, roleManagmentVM.ApplicationUser.Role).GetAwaiter().GetResult();

            }

            return RedirectToAction("Index");
        }

        #endregion
    }
}
//public IActionResult RoleManagment(string userId)
//{
//    RoleManagmentVM roleManagmentVM = new RoleManagmentVM()
//    {
//        ApplicationUser = _unitOfWork.ApplicationUser.Get(u => u.Id == userId),
//        RoleList = _roleManager.Roles.Select(i => new SelectListItem
//        {
//            Text = i.Name,
//            Value = i.Name
//        })
//    };
//    return View(roleManagmentVM);
//}

//[HttpPost]
//public IActionResult RoleManagment(RoleManagmentVM roleManagmentVM)
//{
//    var user = _unitOfWork.ApplicationUser.Get(u => u.Id == roleManagmentVM.ApplicationUser.Id);
//    var roles = _userManager.GetRolesAsync(user).GetAwaiter().GetResult();
//    if (roles.Count > 0)
//    {
//        _userManager.RemoveFromRoleAsync(user, roles[0]).GetAwaiter().GetResult();
//    }
//    _userManager.AddToRoleAsync(user, roleManagmentVM.ApplicationUser.Role).GetAwaiter().GetResult();
//    return RedirectToAction(nameof(Index));

//#endregion
//}