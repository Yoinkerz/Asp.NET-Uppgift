﻿using Microsoft.AspNetCore.Mvc;
using Webapp.Helpers.Repositories;
using Webapp.Models.ViewModels;

namespace Webapp.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ContactFormRepository _formRepository;

        public ContactsController(ContactFormRepository formRepository)
        {
            _formRepository = formRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactFormViewModel viewModel)
        {
            if(ModelState.IsValid)
            {
                await _formRepository.AddAsync(viewModel);
                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }
    }
}
