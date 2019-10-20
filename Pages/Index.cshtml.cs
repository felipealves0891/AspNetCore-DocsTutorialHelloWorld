﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DocsTutorialHelloWorld.Pages
{
    public class IndexModel : PageModel
    {
        public string Message {get; set;}

        public void OnGet()
        {
            Message = "Pagina principal!";
        }
    }
}
