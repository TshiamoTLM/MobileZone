using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MobileZone.Data;
using MobileZone.Data.DataAccess;
using MobileZone.Models;
using MobileZone.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MobileZone.Controllers
{
    [Authorize]
    public class MobileController : Controller
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private int iPageSize = 4;
        public MobileController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }
        [Authorize(Roles ="Admin, Clients")]
        public IActionResult List(string sortBy = "Name", int mobilePage=1)
        {
            IEnumerable<Mobile> mobiles;
            Expression<Func<Mobile, Object>> orderBy;
            string orderByDirection;

            ViewData["NameSortParam"] = sortBy == "Name" ? "Name_desc" : "Name";
            ViewData["PriceSortParam"] = sortBy == "Price" ? "Price_desc" : "Price";

            int iTotalMobile;

            if (sortBy.EndsWith("_desc"))
            {
                sortBy = sortBy.Substring(0, sortBy.Length - 5);
                orderByDirection = "desc";
            }
            else
            {
                orderByDirection = "asc";
            }

            orderBy = p => EF.Property<object>(p, sortBy);
            iTotalMobile = _repositoryWrapper.Mobile.FindAll().Count();
            mobiles = _repositoryWrapper.Mobile.GetMobileWithCategoryDetailsOptions(new QueryOptions<Mobile>
            {
                OrderBy = orderBy,
                OrderByDirection = orderByDirection,
                PageNumber = mobilePage,
                PageSize = iPageSize
            }) ;
            var model = new MobileListViewModel
            {
                Mobiles = mobiles,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = mobilePage,
                    ItemsPerPage = iPageSize,
                    TotalItems = iTotalMobile
                }
            };

            return View(model);

        }
        [Authorize(Roles ="Admin, Clients")]
        public IActionResult Details(int id)
        {
            var mobile = _repositoryWrapper.Mobile.GetById(id);
            return View(mobile);
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Add()
        {
            PopulateCategoryDLL();
            return View();
        }
        [HttpPost]
        [Authorize(Roles ="Admin")]
        public IActionResult Add(Mobile mobile)
        {
            mobile.ManufactureDate = DateTime.Now;
            if (ModelState.IsValid)
            {
                _repositoryWrapper.Mobile.Add(mobile);
                TempData["Message"] = $"{mobile.Name} has been added";
                _repositoryWrapper.Save();
                return RedirectToAction("List");
            }
            else
            {
                PopulateCategoryDLL();
                return View(mobile);
            }
        }
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(int id)
        {
            var mobile = _repositoryWrapper.Mobile.GetById(id);
            PopulateCategoryDLL(mobile.CategoryId);
            return View(mobile);
        }
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit(Mobile mobile)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repositoryWrapper.Mobile.Update(mobile);
                    _repositoryWrapper.Save();
                    TempData["Message"] = $"{mobile.Name} has been updated";
                    return RedirectToAction("List");
                }
                catch(DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }
                PopulateCategoryDLL(mobile.CategoryId);
                return View(mobile);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            return View(_repositoryWrapper.Mobile.GetById(id));
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(Mobile mobile)
        {
            if (mobile != null)
            {
                try
                {
                    _repositoryWrapper.Mobile.Delete(mobile);
                    TempData["Message"] = $"The device has been deleted";
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to delete device. " +
                     "Try again, and if the problem persists, " +
                     "see your system administrator.");
                }
                _repositoryWrapper.Save();
                return RedirectToAction("List");
            }
            else
            {
                return View(mobile);
            }
        }
        private void PopulateCategoryDLL(object selectedCategory = null)
        {
            ViewBag.Categories = new SelectList(_repositoryWrapper.Category.FindAll()
                .OrderBy(g => g.CategoryName),
                "CategoryId", "CategoryName", selectedCategory);
        }
    }
}
