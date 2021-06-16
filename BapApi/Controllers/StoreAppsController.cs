// https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio
// https://entityframework.net/linq-queries

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BapApi.Models;

namespace BapApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreAppsController : ControllerBase
    {
        private readonly StoreAppsContext _context;

        public StoreAppsController(StoreAppsContext context)
        {
            _context = context;
        }

        // GET: api/StoreApps (StoreApps as in StoreAppsController, line 17)
        // Get all the data from the database
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<StoreAppDTO>>> GetStoreApps()
        {
            return await _context.StoreApps.Select(x => StoreAppToDTO(x)).ToListAsync();
        }

        // GET: api/StoreApps/1
        // Get a single row from the database by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<StoreAppDTO>> GetStoreApp(int id)
        {
            var storeApp = await _context.StoreApps.FindAsync(id);

            if (storeApp == null)
            {
                return NotFound();
            }

            return StoreAppToDTO(storeApp);
        }

        // GET: api/StoreApps/FirstTen
        // Get the first ten results from the database aftering ordering the data by Id
        [HttpGet("FirstTen")]
        public async Task<ActionResult<IEnumerable<StoreAppDTO>>> GetStoreTopTen()
        {

            var storeTopTen = await _context.StoreApps.Select(x => StoreAppToDTO(x)).Take(10).ToListAsync();

            if (storeTopTen == null)
            {
                return NotFound();
            }
            
            return storeTopTen; 
        }

        // POST: api/StoreApps
        // Add a new record to the database

        // Delete: api/StoreApps/1
        // Delete a single row from the database by Id

        // DTO helper method. "Production apps typically limit the data that's input and returned using a subset of the model"
        private static StoreAppDTO StoreAppToDTO(StoreApp storeApp) =>
            new StoreAppDTO
            {
                Id = storeApp.Id,
                Name = storeApp.Name
            };
    }

}
