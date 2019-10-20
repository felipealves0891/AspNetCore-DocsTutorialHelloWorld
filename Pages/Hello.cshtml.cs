using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DocsTutorialHelloWorld.Pages
{

    public class HelloModel : PageModel
    {
        public string Message {get;set;}

        public void OnGet()
        {
            Message = "Hello World";
        }        
    }
}