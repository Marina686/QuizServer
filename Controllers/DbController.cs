using Microsoft.AspNetCore.Mvc;
using QuizServer.Data;
using QuizServer.Models; 
using System.Collections.Generic; 

namespace QuizServer.Controllers
{
    [ApiController]
    [Route("api/Db")]
    public class DbController : ControllerBase
    {
        private readonly DataContext _context;

        public DbController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DbModel>> GetAllData()
        {
            return Ok(_context.DbModels);
        }

         
      }
    }
