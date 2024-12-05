using Microsoft.AspNetCore.Mvc;
using Dating_app_1.Data;
using Dating_app_1.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Dating_app_1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext context;

        public UsersController(DataContext _context) 
        {
            context = _context;
        }

        [HttpGet]
        public async Task< ActionResult <IEnumerable<App_User>>> Get_Users()
        {
            return await context.AppUsers.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task< ActionResult<App_User>> Get_Users(int id)
        {

            return await context.AppUsers.FindAsync(id);  

             
        } 
    }
}
