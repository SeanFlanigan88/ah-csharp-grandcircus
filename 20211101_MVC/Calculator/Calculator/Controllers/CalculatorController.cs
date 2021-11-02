using Calculator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: CalculatorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CalculatorController/Details/5
        public ActionResult Result([Bind("num1", "num2", "operation")]Calculation calculation)
        {

            decimal result = 0;
            switch (calculation.operation)
            {
                case "Plus": 
                    result = calculation.num1 + calculation.num2; 
                    break;
                case "Minus":
                    result = calculation.num1 - calculation.num2;
                    break;
                case "Multiply":
                    result = calculation.num1 * calculation.num2;
                    break;
                case "Divide":
                    result = calculation.num1 / calculation.num2;
                    break;
            }

            ViewData["calculation"] = calculation;
            ViewBag.Operation = calculation.operation;
            ViewData["Result"] = result;

            return View("Result");
        }

        // GET: CalculatorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalculatorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculatorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CalculatorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CalculatorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CalculatorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
