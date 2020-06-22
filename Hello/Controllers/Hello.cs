using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        public static string CreateMessage(string language, string name)
        {
            string result = $"Hello {name}.";

            if (language == "Spanish")
                result = $"Holla {name}.";

            if (language == "French")
                result = $"Bonjour {name}.";

            if (language == "Portuguese")
                result = $"Olá {name}.";

            if (language == "Greek")
                result = $"Χαίρετε {name}.";

            return result;
        }
        
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld'>" +
                "<input type='text' name='name' />" +
                "<select name='language'>" +
                "<option value='English'>English</option>" +
                "<option value='Spanish'>Spanish</option>" +
                "<option value='French'>French</option>" +
                "<option value='Portuguese'>Portuguese</option>" +
                "<option value='Greek'>Greek</option>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";

            return Content(html,"text/html"); ;
        }
        
        // GET: /<controller>/welcome?name=value or GET: /<controller>/welcome/name
        //[HttpGet]
        // POST: /<controller>/welcome
        //if()
        [HttpGet("welcome/{name?}")]

        [HttpPost]
        public IActionResult Welcome(string language = "", string name = "World")
        {
            
            return Content(CreateMessage(language, name), "text/html");
        }

    }
}