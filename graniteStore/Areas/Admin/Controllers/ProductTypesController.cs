﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using graniteStore.Data;
using graniteStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace graniteStore.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ProductTypesController : Controller
    {


        private readonly Data.ApplicationDbContext _db;


        public ProductTypesController(ApplicationDbContext db)
        {

            _db = db;

        }

        public IActionResult Index()
        {
           
            return View(_db.ProductTypes.ToList());
        }


        public IActionResult Create()
        {

            return View();
        }

        


        [HttpPost]

        public IActionResult Create(ProductTypes productTypes)
        {
            
            if (ModelState.IsValid)
            {
                _db.Add(productTypes);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));


            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = _db.ProductTypes.Find(id);

            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }
        [HttpPost]
        public IActionResult Edit(int id, ProductTypes productTypes)
        {
            if (id != productTypes.id)
            {
                return NotFound();


            }


            if (ModelState.IsValid)
            {
                _db.Update(productTypes);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));


            }

            return View();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productType = _db.ProductTypes.Find(id);

            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }
        [HttpPost]
        public IActionResult Details(int id, ProductTypes productTypes)
        {
            if (id != productTypes.id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {

                return NotFound();
            }
            var productType = _db.ProductTypes.Find(id);

            if (productType == null)
            {
                return NotFound();
            }

            return View(productType);
        }
        [HttpPost]

        public IActionResult Delete(int id)
        {

            var productTypes = _db.ProductTypes.Find(id);
            _db.ProductTypes.Remove(productTypes);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}