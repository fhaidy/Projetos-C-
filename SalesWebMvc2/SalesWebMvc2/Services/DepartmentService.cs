using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc2.Models;

namespace SalesWebMvc2.Services {
    public class DepartmentService {
        private readonly SalesWebMvc2Context _context;
        public DepartmentService(SalesWebMvc2Context context) {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() {
            return await _context.Department.OrderBy(obj => obj.Name).ToListAsync();
        }
    }
}
