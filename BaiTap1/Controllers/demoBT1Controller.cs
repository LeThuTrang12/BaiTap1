using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap1.Controllers
{
    public class demoBT1Controller : Controller
    {
        // GET: demoBT1
        public ActionResult GPT()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GPT(string soA, string soB)
        {
            double soa = Convert.ToDouble(soA);
            double sob = Convert.ToDouble(soB);
            double ketqua = -sob / soa;
            ViewBag.Giaipt = ketqua;
            return View();
        }
    }
}