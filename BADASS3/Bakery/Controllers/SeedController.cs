﻿using Bakery.Database;
using Bakery.Model;
using Microsoft.AspNetCore.Mvc;



namespace Bakery.Controllers
{
    public class SeedController : Controller
    {
        private BakeryDbContext _context;
        public SeedController(BakeryDbContext context) => _context = context;
    }
}
