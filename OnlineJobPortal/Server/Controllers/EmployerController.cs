using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineJobPortal.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineJobPortal.Shared;

namespace OnlineJobPortal.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployerController : ControllerBase
    {
        private readonly ILogger<EmployerController> _logger;
        private readonly OnlineJobPortalContext _ctx;

        public EmployerController(ILogger<EmployerController> logger, OnlineJobPortalContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var employer = await _ctx.Employers.ToListAsync();
            return Ok(employer);
        }
        [HttpGet]
        [Route("{EMPID}")]
        public async Task<IActionResult> GetById(int EMPID)
        {
            var employer = await _ctx.Employers.Where(e => e.Id == EMPID).FirstOrDefaultAsync();
            return Ok(employer);
        }
        [HttpPut]
        [Route("{EMPID}")]
        public async Task<IActionResult> Update(int EMPID,Employer employer) 
        {
            _ctx.Employers.Update(employer);
            await _ctx.SaveChangesAsync();
            return Ok(employer);
        }
        [HttpDelete]
        [Route("{EMPID}")]
        public async Task<IActionResult> Delete(int EMPID)
        {
            var employer = await _ctx.Employers.Where(e => e.Id == EMPID).FirstOrDefaultAsync();
            _ctx.Employers.Remove(employer);
            await _ctx.SaveChangesAsync();
            return Ok(employer);

        }
    }
}
/*
 [HttpGet]
		public async Task<ActionResult<IEnumerable<Category>>> GetCatogories()
		{
			return await _context.Catogories.ToListAsync();
		}
 */