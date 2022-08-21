using System;
using U21557277__HW04.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace U21557277__HW04.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LoginSuccess(UserModel userModel)
        {
            if (userModel.UserName == "Martha" && userModel.Password == "ILoveGod")
            {
                return View("LoginSuccess", userModel);
            }
            else
            {
                return View("LoginFailed", userModel);
            }
        }

    }
}