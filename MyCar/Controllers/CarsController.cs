﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCar.Context;
using System.Threading.Tasks;

namespace MyCar.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {

        private readonly AppDbContext _appDbContext;

        public CarsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        } 

        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            return Ok(new
            {
                success = true, 
                data = await _appDbContext.Cars.ToListAsync()
            });
        }
    }
}
