using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CsharpWeb.Pages
{
    public class FeaturedModel : PageModel
    {
        private readonly ILogger<FeaturedModel> _logger;

        public FeaturedModel(ILogger<FeaturedModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
