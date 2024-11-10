using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvcAuction.Data;
using mvcAuction.Data.Services;
using mvcAuction.Models;

namespace mvcAuction.Controllers
{
    public class ListingsController : Controller
    {
        private readonly IListingsService _listingsService;

        public ListingsController(IListingsService listingsService)
        {
            _listingsService = listingsService;
        }

        // GET: Listings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _listingsService.GetAll();
            return View(await applicationDbContext.ToListAsync());
        }

        
    }
}
