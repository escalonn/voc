using System;
using System.Collections.Concurrent;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ServerSide.Models;

namespace ServerSide.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private static readonly ConcurrentBag<GroceryStore> _groceryStores;
        private static int maxId;

        static StoreController()
        {
            _groceryStores = new ConcurrentBag<GroceryStore>
            {
                new GroceryStore { Id = 1, Name = "Market Base", Address = "1882 State Street" },
                new GroceryStore { Id = 2, Name = "Food Land", Address = "4122 Aaron Smith Drive" }
            };
            maxId = _groceryStores.Max(g => g.Id);
        }

        [HttpGet]
        public IEnumerable<GroceryStore> Get()
        {
            return _groceryStores.OrderBy(g => g.Id);
        }

        [HttpGet("{id}")]
        public ActionResult<GroceryStore> GetById(int id)
        {
            GroceryStore grocery = _groceryStores.FirstOrDefault(g => g.Id == id);
            if (grocery == null)
            {
                return NotFound();
            }
            return grocery;
        }

        [HttpPost]
        public ActionResult<GroceryStore> Create(GroceryStore groceryStore)
        {
            throw new NotImplementedException();
        }
    }
}
