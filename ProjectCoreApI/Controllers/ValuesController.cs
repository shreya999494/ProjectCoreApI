using Microsoft.AspNetCore.Mvc;
using ProjectCoreApI.Database;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectCoreApI.Controllers
{
    [Route("api/Values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ShoppyDbContext _context;

        public ValuesController()
        {
            _context = new ShoppyDbContext();
        }
        // GET: api/<ValuesController>
        [Route("~/api/GetUsers")]
        [HttpGet]
        public IEnumerable<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        [Route("~/api/CreateUser")]
        [HttpPost]
        public int CreateUser(User user)
        {

            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UId;
        }

        //[Route("~/api/GetDetails")]
        //public IEnumerable<Brand> GetDetails()
        //{
        //    return _context.Brands.ToList();
        //}

        //[Route("~/api/GetShoppingDetails")]
        //public IEnumerable<Item> GetShoppingDetails()
        //{
        //    return _context.Items.ToList();

        //}

    }
}
