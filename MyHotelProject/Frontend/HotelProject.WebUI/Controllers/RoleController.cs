using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Models.AppRole;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRole(AddAppRoleViewModel addAppRoleView)
        {
            AppRole appRole = new AppRole() {

                Name = addAppRoleView.RoleName
            };
            var result = await _roleManager.CreateAsync(appRole);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return View();
        }


        public async Task<IActionResult> DeleteRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            UpdateAppRoleViewModel updateAppRoleViewModel = new UpdateAppRoleViewModel()
            {
                RoleId = value.Id,
                RoleName = value.Name
            };

            return View(updateAppRoleViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(UpdateAppRoleViewModel updateAppRoleViewModel)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == updateAppRoleViewModel.RoleId);
            values.Name = updateAppRoleViewModel.RoleName;
            await _roleManager.UpdateAsync(values);
            return RedirectToAction("Index");
        }

    }
}
