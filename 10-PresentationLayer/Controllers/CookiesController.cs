using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace _10_ThreeLayerProject.PL.Controllers
{
    [Route("Cookies")]
    public class CookiesController : Controller
    {
        private const string cookieKey = "mycookie";
        [Route("AddCookie")]
        public IActionResult AddCookie()
        {
            string cookieValue = Request.Cookies[cookieKey];
            return View(cookieValue as object);
        }
        [Route("AddCookie")]
        [HttpPost]
        public string AddCookie(string value, DateTime dateTime)
        {
            var options = new CookieOptions();
            options.Expires = dateTime;

            Response.Cookies.Append(cookieKey, value, options);
            return "Cookie added";
        }
    }
}
