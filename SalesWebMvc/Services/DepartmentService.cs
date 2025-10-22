using SalesWebMvc.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }


        // sincrona
        //public List<Department> FindAll()
        //{
        //    return _context.Department.OrderBy(x => x.Name).ToList();
        //}

        // Assincrona, deixa a aplicação mais rapida, "fluida", roda em Thread
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
