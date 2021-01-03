using SalesRecordsDotNet5.Data;
using SalesRecordsDotNet5.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesRecordsDotNet5.Services
{
    public class DepartmentService
    {
        private readonly SalesRecordsDotNet5Context _context;

        public DepartmentService(SalesRecordsDotNet5Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
