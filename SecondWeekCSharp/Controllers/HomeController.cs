using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SecondWeekCSharp.Models;

namespace SecondWeekCSharp.Controllers
{
    

    public class HomeController : Controller
    {
        



        public IActionResult makeit()
        {

            var tryit = makeRandoms.RandomString(13);
            var mymodel = new Pseudo();
            return View("pseudoview", mymodel);
        }
        [HttpPost("updateit")]
        public IActionResult updateit(Pseudo incoming, int myhiddencount)
        {
            myhiddencount++;
            incoming.generatenew();
            incoming.count = myhiddencount;
            return View(incoming);

        }
       

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("dojodachi")]
        public IActionResult DojoDachiAction()
        {
            DojoDachi.EndGameConditions();
            var myDachi = new dojoDachi_Instance();
            //myDachi.initial = false;
            return View(myDachi);
          
        }

        public IActionResult FeedMe()
        {
            DojoDachi.Feed();
            return RedirectToAction("DojoDachiAction");
        }

        public IActionResult ResetMe()
        {
            DojoDachi.reset();
            return RedirectToAction("DojoDachiAction");
        }

      
        public IActionResult PlayMe()
        {
            DojoDachi.Play();
            //myDachi.Play();
            return RedirectToAction("DojoDachiAction");
        }

        public IActionResult WorkeMe()
        {
            DojoDachi.Work();
            return RedirectToAction("DojoDachiAction");
        }

        public IActionResult SleepMe()
        {
            DojoDachi.Sleep();
            return RedirectToAction("DojoDachiAction");

        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
