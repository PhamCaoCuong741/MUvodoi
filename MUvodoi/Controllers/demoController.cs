using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaiTap2.Models;

namespace BaiTap2.Controllers
{
    public class DemoBT2Controller : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        public ActionResult GPT()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPT(string soA, string soB)
        {
            double so1 = Convert.ToDouble(soA);
            double so2 = Convert.ToDouble(soB);
            double ketqua = gpt.GPT(so1, so2);
            ViewBag.Giaipt = ketqua;
            return View();
        }
    }
}