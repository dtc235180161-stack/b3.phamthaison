using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using b3.PhamThaiSon.Models.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using b3.PhamThaiSon.Models;
using b3.PhamThaiSon.Models.Data;

namespace b3.PhamThaiSon.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {
            var _categories = Models.Data.SeedData.categories;
            return View(_categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var categories = SeedData.categories.FirstOrDefault(c => c.id == id);

            if (categories == null)
            {
                return NotFound();
            }

            return View(categories);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.category cate)
        {
            if (ModelState.IsValid)
            {
                int maxId = SeedData.categories.Max(c => c.id);
                cate.id = maxId + 1;
                SeedData.categories.Add(cate);
                return RedirectToAction(nameof(Index));
            }
            return View(cate);

        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var category = SeedData.categories.FirstOrDefault(c => c.id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromForm] Models.category  category)
        {
            var existingCategory = SeedData.categories.FirstOrDefault(c => c.id == category.id);
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                existingCategory.Name = category.Name;
                existingCategory.Description = category.Description;
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

      

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var category = SeedData.categories.FirstOrDefault(c => c.id == id);
            if (category == null)
            {
                return NotFound();
            }
            SeedData.categories.Remove(category);
            return RedirectToAction(nameof(Index));
        }
    }
    }
