using Microsoft.AspNetCore.Mvc;
namespace Portfolio1
{
    public class HomeController : Controller
    {
        //REQUESTS
        //localhost:5000/

        [HttpGet("")]
        public string Index()
        {
            return "This is my Index";
        }

        //localhost:5000/hello
        [Route("projects")]
        [HttpGet]
        public string Hello()
        {
            return "These are my projects";
        }
        [HttpGet("contacts")]
        public string Contacts()
        {
            return "This is my Contact!";
        }
    }
}