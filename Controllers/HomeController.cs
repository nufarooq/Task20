using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using Task20_MVC.Models;

namespace Task20_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Value = "India", Text = "India" });
            list.Add(new SelectListItem() { Value = "U.S.A", Text = "U.S.A" });
            list.Add(new SelectListItem() { Value = "UAE", Text = "UAE" });
            list.Add(new SelectListItem() { Value = "U.K", Text = "U.K" });
            list.Add(new SelectListItem() { Value = "China", Text = "China" });
            list.Add(new SelectListItem() { Value = "Russia", Text = "Russia" });

            User model = new User();
            model.Countrylst = list;
            return View(model);
        }

        public ActionResult Validate()
        {
            if (ModelState.IsValid)
            {

                HttpCookie Cookie;
                Cookie = new HttpCookie("userdata");
                Cookie["username"] = Request.Form["UserName"].ToString();
                Response.Cookies.Add(Cookie);
                //string username = Request.Cookies["username"].Value;
                HttpCookie reqCookies = Request.Cookies["userdata"];
                if (reqCookies != null)
                {
                    string User_name = reqCookies.Value.ToString();
                    ViewBag.Message = User_name + " your data has been saved.";
                }


                List<SelectListItem> list = new List<SelectListItem>();
                list.Add(new SelectListItem() { Value = "India", Text = "India" });
                list.Add(new SelectListItem() { Value = "U.S.A", Text = "U.S.A" });
                list.Add(new SelectListItem() { Value = "UAE", Text = "UAE" });
                list.Add(new SelectListItem() { Value = "U.K", Text = "U.K" });
                list.Add(new SelectListItem() { Value = "China", Text = "China" });
                list.Add(new SelectListItem() { Value = "Russia", Text = "Russia" });


                User model = new User();
                model.Countrylst = list;
                return View("Index", model);
            }
            return View("Index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}