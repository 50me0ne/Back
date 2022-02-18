using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Collections;
using System.Data;
using Back.Data;
using Back.Models;

namespace Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration;

        public ReceiptsController(IConfiguration configuration, ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_context.Receipt.ToList());
        }
        [HttpPost]
        public JsonResult Create(ReceiptView r)
        {
            Receipt rec = new Receipt(r);
            if (ModelState.IsValid)
            {
                _context.Receipt.Add(rec);
                _context.SaveChanges();
            }
            return new JsonResult("Guardado");
        }
    }
}
