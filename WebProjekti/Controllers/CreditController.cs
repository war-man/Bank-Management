﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Credit;
using DataAccessLayer.Persons;
using EntityLayer.Credits;
using EntityLayer.Persons;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebProjekti.Controllers
{
    public class CreditController : Controller
    {
        private readonly CreditRepository _creditRepository;
        private readonly PersonRepository _personRepository;

        public CreditController(CreditRepository creditRepository, PersonRepository personRepository)
        {
            _creditRepository = creditRepository;
            _personRepository = personRepository;
        }

        [Authorize(Roles = "Admin,Super Admin")]
        [HttpGet]
        public async Task<IActionResult> InsertCredit()
        {
            ViewBag.Clients = await _personRepository.GetPersons();
            return View();
        }

        [Authorize(Roles = "Admin,Super Admin")]
        [HttpPost]
        public async Task<IActionResult> InsertCredit(Credits obj)
        {
            if(await _creditRepository.InsertCredit(obj) != null)
            {
                return RedirectToAction("ListCredits");
            }
            ViewBag.ErrorTitle = $"Error";
            ViewBag.ErrorMessage = $"Not Register";
            return View("Error");
        }


        [Authorize(Roles = "Admin,Super Admin")]
        [HttpPost]
        public async Task<IActionResult> DeleteCredit(int id)
        {
            if(await _creditRepository.DeleteCredit(id) != -1)
            {
                return RedirectToAction("ListCredits");
            }
            ViewBag.ErrorTitle = $"Error";
            ViewBag.ErrorMessage = $"Not Deleted";
            return View("Error");
        }

        [Authorize(Roles = "Admin,Super Admin")]
        [HttpPost]
        public async Task<IActionResult> UpdateCredit(Credits obj)
        {
            if(await _creditRepository.UpdateCredit(obj) != null)
            {
                return RedirectToAction("ListCredits");
            }
            ViewBag.ErrorTitle = $"Error";
            ViewBag.ErrorMessage = $"Not Upddated";
            return View("Error");
        }

        [Authorize(Roles = "Admin,Super Admin")]
        [HttpGet]
        public async Task<IActionResult> ListCredits()
        {
            List<Credits> credits = await _creditRepository.GetCredits();
            return View(credits);
        }

        [Authorize(Roles = "Admin,Super Admin")]
        [HttpGet]
        public async Task<IActionResult> UpdateCredit(int id)
        {
            Credits obj = await _creditRepository.GetCredit(id);
            List<Persons> persons = new List<Persons>();
            persons.Add(obj.Client);
            ViewBag.Persons = persons;
            return View(obj);
        }

        [Authorize(Roles = "Admin,Super Admin,User")]
        [HttpGet]
        public async Task<IActionResult> CreditDetails(string id)
        {
            Credits obj = await _creditRepository.GetCredit(id);
            return View(obj);
        }

        [Authorize(Roles = "Admin,Super Admin,User")]
        [HttpGet]
        public async Task<IActionResult> MyCredits(string email)
        {
            List<Credits> credits = await _creditRepository.MyCredits(email);
            return View(credits);
        }
    }
}