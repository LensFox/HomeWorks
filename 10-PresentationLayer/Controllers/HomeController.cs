using _10_ThreeLayerProject.BLL;
using _10_Models;
using Microsoft.AspNetCore.Mvc;

namespace _10_ThreeLayerProject.PL.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserService userService;
        public HomeController(UserService userService)
        {
            this.userService = userService;
        }
        public IActionResult Index()
        {
            var allUsers = userService.ReadAll();
            return View(allUsers);
        }
        public IActionResult AddUser()
        {
            return PartialView();
        }
        public IActionResult DeleteUser()
        {
            return PartialView();
        }
        public string AddUserProceedResult(User user)
        {
            userService.Create(user);
            return "User added";
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
    }
}
