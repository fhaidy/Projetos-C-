using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc2.Models;

namespace SalesWebMvc2.Services {
    public class DepartmentService {
        private readonly SalesWebMvc2Context _context;
        public DepartmentService(SalesWebMvc2Context context) {
            _context = context;
        }

        public List<Department> FindAll() {
            return _context.Department.OrderBy(obj => obj.Name).ToList();
        }
    }
}
