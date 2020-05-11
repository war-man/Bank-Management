﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Cards;
using DataAccessLayer.Reports;
using EntityLayer.Accounts;
using EntityLayer.Transactions;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebProjekti.Controllers
{
    public class TransactionController : Controller
    {
        private readonly TransactionRepository _transactionRepository;
        private readonly AccountRepository _accountRepository;
        private readonly AccountReports _accountReports;
        private static Accounts CurrentAccount;
        public TransactionController(TransactionRepository transactionRepository, AccountRepository accountRepository, AccountReports accountReports)
        {
            this._transactionRepository = transactionRepository;
            this._accountRepository = accountRepository;
            this._accountReports = accountReports;
            CurrentAccount = _accountRepository.GetAccount((int)AccountController.CurrentClient.PersonId); 
            if (CurrentAccount != null)
            {
                ViewBag.AccountNumber = CurrentAccount.AccountNumber;
                ViewBag.CardNumber = CurrentAccount.CardNumber;
            }
        }

        [HttpGet]
        public IActionResult Transfer()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MakeTransfer(Transfer obj)
        {
            try
            {
                obj.ClientID = (int)CurrentAccount.ClientId;
                obj.ExecutionDate = DateTime.Now;
                Accounts toAcc = _accountRepository.GetAccount(obj.ToAccountNumber);
                if(toAcc == null)
                {
                    return DisplayError("Not Successful", "This Account Not Exist");
                }
                if (await _transactionRepository.Insert(obj) != null)
                {
                    return RedirectToAction("ConfirmTransaction");
                }
                return DisplayError("Not Successful", "Something went wrong");
            }
            catch (Exception ex)
            {
                return DisplayError("Not Successful", ex.Message);
            }
        }

        [HttpGet]
        public IActionResult ConfirmTransaction()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Deposit()
        {
            return View();
        }

        public async Task<IActionResult> MakeDeposit(Deposit obj)
        {
            try
            {
                GetAtributes(obj);
                Accounts acc = _accountRepository.GetAccount(obj.AccountNumber);
                if (acc == null)
                {
                    return DisplayError("Not Successful", "This Account Not Exist");
                }
                if (await _transactionRepository.Insert(obj) != null)
                {
                    return RedirectToAction("ConfirmTransaction");
                }
                return DisplayError("Not Successful", "Something went wrong");
            }
            catch (Exception ex)
            {
                return DisplayError("Not Successful", ex.Message);
            }
        }

        private IActionResult DisplayError(string title ,string message)
        {
            ViewBag.ErrorTitle = title;
            ViewBag.ErrorMessage = message;
            return View("Error");
        }

        private void GetAtributes(Transaction obj)
        {
            obj.ClientID = (int)AccountController.CurrentClient.PersonId;
            obj.ExecutionDate = DateTime.Now;
        }

        [HttpGet]
        public IActionResult WithDrawal()
        {
            return View();
        }

        public async Task<IActionResult> MakeWithDrawal(WithDrawal obj)
        {
            try
            {
                GetAtributes(obj);
                Accounts acc = _accountRepository.GetAccount(obj.AccountNumber);
                if (acc == null)
                {
                    return DisplayError("Not Successful", "This Account Not Exist");
                }
                if (await _transactionRepository.Insert(obj) != null)
                {
                    return RedirectToAction("ConfirmTransaction");
                }
                return DisplayError("Not Successful", "Something went wrong");
            }
            catch (Exception ex)
            {
                return DisplayError("Not Successful", ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> ListDeposits()
        {
            List<Deposit> deposits = await _transactionRepository.GetDeposits((int)AccountController.CurrentClient.PersonId);
            ViewBag.DepositsCount = deposits.Count;
            ViewBag.TransferCount = (await _transactionRepository.GetTransfers((int)AccountController.CurrentClient.PersonId)).Count;
            ViewBag.DrawalsCount = (await _transactionRepository.GetWithDrawals((int)AccountController.CurrentClient.PersonId)).Count;
            return View(deposits);
        } 

        [HttpGet]
        public async Task<IActionResult> ListTransfers()
        {
            List<Transfer> transfers = await _transactionRepository.GetTransfers((int)AccountController.CurrentClient.PersonId);
            ViewBag.TransferCount = transfers.Count;
            ViewBag.DrawalsCount = (await _transactionRepository.GetWithDrawals((int)AccountController.CurrentClient.PersonId)).Count;
            ViewBag.DepositsCount = (await _transactionRepository.GetDeposits((int)AccountController.CurrentClient.PersonId)).Count;
            return View(transfers);
        }

        [HttpGet]
        public async Task<IActionResult> ListDrawals()
        {
            List<WithDrawal> drawals = await _transactionRepository.GetWithDrawals((int)AccountController.CurrentClient.PersonId);
            ViewBag.DrawalsCount = drawals.Count;
            ViewBag.TransferCount = (await _transactionRepository.GetTransfers((int)AccountController.CurrentClient.PersonId)).Count;
            ViewBag.DepositsCount = (await _transactionRepository.GetDeposits((int)AccountController.CurrentClient.PersonId)).Count;
            return View(drawals);
        }

        [HttpGet]
        public async Task<IActionResult> Balance()
        {
            ViewBag.Balance = _accountRepository.GetBalance((int)AccountController.CurrentClient.PersonId);
            ViewBag.DataDeposits = JsonConvert.SerializeObject(await _accountReports.GetRaports((int)AccountController.CurrentClient.PersonId, "sp_GetDepositsForMonth"));
            ViewBag.DataTransfers = JsonConvert.SerializeObject(await _accountReports.GetRaports((int)AccountController.CurrentClient.PersonId, "sp_GetTransfersForMonth"));
            ViewBag.DataDrawals = JsonConvert.SerializeObject(await _accountReports.GetRaports((int)AccountController.CurrentClient.PersonId, "sp_GetDrawalsForMonth"));
            ViewBag.LastDeposits = await _accountReports.GetDeposits((int)AccountController.CurrentClient.PersonId);
            ViewBag.LastTransfers = await _accountReports.GetTransfers((int)AccountController.CurrentClient.PersonId);
            ViewBag.LastDrawals = await _accountReports.GetWithDrawals((int)AccountController.CurrentClient.PersonId);
            return View();
        }

    }
}