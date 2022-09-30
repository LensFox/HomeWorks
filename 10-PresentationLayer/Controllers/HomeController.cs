using _10_ThreeLayerProject.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using _10_ThreeLayerProject.PL.Models;
using AutoMapper;
using _10_ThreeLayerProject.BLL.Entitites;
using System.Collections.Generic;

namespace _10_ThreeLayerProject.PL.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService userService;
        private IConfiguration Configuration { get; }
        private readonly IMapper mapper;
        public HomeController(IUserService userService, IConfiguration configuration, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
            Configuration = configuration;

        }

        public IActionResult Index()
        {
            var result = new List<UserModel>();
            var users = userService.ReadAll();
            foreach (var item in users)
            {
                result.Add(mapper.Map<UserModel>(item));
            }
            return View(result);
        }

        public PartialViewResult AddUser()
        {
            return PartialView();
        }
        public IActionResult DeleteUser()
        {
            return PartialView();
        }

        [HttpPost]
        public string AddUser(UserModel userModel)
        {
            userService.Create(mapper.Map<User>(userModel));
            return "User added";
        }

        [HttpGet]
        public IActionResult UpdateUser()
        {
            return View();
        }

        [HttpPost]
        public string UpdateUser(UserModel userModel)
        {
            userService.UpdateById(mapper.Map<User>(userModel));
            return "User updated";
        }

        public string DeleteUserProceedResult(string input)
        {
            int id;
            if (int.TryParse (input, out id))
            {
                userService.Delete(id);
            }
            else
            {
                userService.DeleteByName(input);
            }
                return "User is deleted";
        }
        public IActionResult Config()
        {
            string message = Configuration["MyMessage"];
            ViewData["MyMessage"] = message;
            return PartialView();
        }
    }
}
