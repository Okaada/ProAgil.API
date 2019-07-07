using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAgil.API.Data;
using ProAgil.API.Model;

namespace ProAgil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext _context { get; }
        //OR public readonly DataContext;
          

        public ValuesController(DataContext context)
        {
            _context = context;

        }
        // GET api/values
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _context.Events.ToListAsync();
                //Return the StatusCode 200
                return Ok(results);
            }
            catch (System.Exception)
            {
                //Isn't a good return to uderstand the error
                //return BadRequest();
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Failed to Connect the Database");
            }
          
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {

            try
            {
                var result = await _context.Events.FirstOrDefaultAsync(x => x.EventId == id); 
                return Ok(result);
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Failed to Connect the Database dude");
            }

        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
