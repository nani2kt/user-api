using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Demo.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeContext context;

        public DepartmentRepository(EmployeeContext context)
        {
            this.context = context;
        }

        public Department GetDepartment(int departmentId)
        {
            return context.Departments
                .FirstOrDefault(d => d.DepartmentId == departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return context.Departments;
        }
    }
}
