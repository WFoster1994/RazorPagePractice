using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPCorePractice.Pages
{
    public class NameInputModel : PageModel
    {
        public String name;
        
        public void OnGet()
        {

        }

        public void OnPost()
        {
            this.name = Request.Form["name"];
        }
    }
}