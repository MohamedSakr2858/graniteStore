﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using graniteStore.Data;
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
    }
}