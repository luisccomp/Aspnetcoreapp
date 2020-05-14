using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Webapp.Models;
using Webapp.Services;

namespace Webapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly JsonFileProductService _jsonFileProductService;

        public IndexModel(ILogger<IndexModel> logger, JsonFileProductService jsonFileProductService)
        {
            _logger = logger;
            _jsonFileProductService = jsonFileProductService;
        }

        public IEnumerable<Product> Products { get; private set;}

        public void OnGet()
        {
            Products = _jsonFileProductService.GetProducts();
        }
    }
}
