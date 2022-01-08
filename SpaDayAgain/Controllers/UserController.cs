using Microsoft.AspNetCore.Mvc;
using SpaDayAgain.Models;

namespace SpaDayAgain.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        //TODO: Add string verify as an argument to this method
        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            ViewBag.username = newUser.Username;
            //TODO: Test whether Password equals verify
            if (newUser.Password.Equals(verify))
            {
                return View("Index");
            }
            else
            {
                ViewBag.email = newUser.Email;
                return View("Add");
            }

            //TODO: If password does not equal verify, re-render form and add error message to ViewBag
            /*TODO: If password does not equal verify, add newUser's username and email to ViewBag 
             * so they don't have to be re-entered.
             */

            
        }


    }
}
