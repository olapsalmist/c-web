using System;
using Microsoft.AspNetCore.Mvc;

namespace rootweb.Controllers
{
    public class SquareController : Controller
    {
        public ActionResult Squareroot(int firstnumber, int secondnumber)
        {
            double number1 = Math.Sqrt(firstnumber);
            double number2 = Math.Sqrt(secondnumber);
            ViewBag.firstnumber= firstnumber;
            ViewBag.secondnumber= secondnumber;
            ViewBag.result1= number1;
            ViewBag.result2= number2;
            return View();
        }

    }
}
