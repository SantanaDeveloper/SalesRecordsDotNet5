using Microsoft.EntityFrameworkCore;
using SalesRecordsDotNet5.Data;
using SalesRecordsDotNet5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesRecordsDotNet5.Services
{
    public class DepartmentService
    {
        private readonly SalesRecordsDotNet5Context _context;

        public DepartmentService(SalesRecordsDotNet5Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
