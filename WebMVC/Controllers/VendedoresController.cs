﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVC.Models;
using WebMVC.Services;

namespace WebMVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;
        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        public IActionResult Index()
        {
            var list = _vendedorService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorService.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
