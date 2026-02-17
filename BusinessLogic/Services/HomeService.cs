using BusinessLogic.Entities;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//zfgdfgdfag
namespace BusinessLogic.Services
{
    public class HomeService
    {
        private readonly ApplicationDbContext _context;

        public HomeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> GetAll()
        {
            //double q = 0;

            //await Task.Run(() =>
            //{

            //    for (int i = 0; i < 100000; ++i)
            //    {
            //        q = q * 2 / Math.Log(i + 1);
            //    }

            //});

            List<Item> items = await _context.Items.ToListAsync();
            return items;
        }
    }
}