using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using QueenAttackApp;
using System;

namespace QueeAttackApp.Controllers
{
    public class QueenAttackController : Controller
    {
        [HttpGet("/queen")]
        public ActionResult Form()
        {
            return View(null);
        }

        [HttpPost("/queen")]
        public ActionResult Create()
        {
            QueenAttack newQueenAttack = new QueenAttack();
            Console.WriteLine("Hey");
            Console.WriteLine(int.Parse(Request.Form["queenCol"]));
            return View("Form", newQueenAttack.CheckAll(int.Parse(Request.Form["queenRow"]), int.Parse(Request.Form["queenCol"]), int.Parse(Request.Form["pieceRow"]), int.Parse(Request.Form["pieceCol"])));
        }
    }
}
