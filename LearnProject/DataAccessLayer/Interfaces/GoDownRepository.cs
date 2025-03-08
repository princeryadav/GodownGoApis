using DataAccessLayer.Data;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public class GoDownRepository : IGoDownRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public GoDownRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<GoDown>> GetGoDownsAsync()
        {
            //return await _dbContext.GoDowns.ToListAsync();
            return await Task.FromResult(GetHardcodedGoDowns());

        }

        private List<GoDown> GetHardcodedGoDowns()
        {
            return new List<GoDown>
            {
                new GoDown
                    {
                        Id = 1,
                        Name = "Kalher Warehouse",
                        Products = new List<Product>
                        {
                            new Product { Id = 101, Name = "Laptop", Quantity = 50 },
                            new Product { Id = 102, Name = "Mouse", Quantity = 150 },
                            new Product { Id = 103, Name = "Keyboard", Quantity = 100 }
                        }
                    },
                new GoDown
                    {
                        Id = 2,
                        Name = "Bhiwandi Warehouse",
                        Products = new List<Product>
                        {
                            new Product { Id = 201, Name = "Monitor", Quantity = 30 },
                            new Product { Id = 202, Name = "CPU", Quantity = 40 },
                            new Product { Id = 203, Name = "RAM", Quantity = 200 }
                        }
                    },
                new GoDown
                    {
                        Id = 3,
                        Name = "Thane Warehouse",
                        Products = new List<Product>
                        {
                            new Product { Id = 301, Name = "Printer", Quantity = 25 },
                            new Product { Id = 302, Name = "Scanner", Quantity = 15 },
                            new Product { Id = 303, Name = "Projector", Quantity = 10 }
                        }
                    }
            };
        }
    }
}
