using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_Project.DAL
{
    internal interface _IDepartmentRepository:IDisposable
    {
        IEnumerable<Department> GetAllDepartment();

        Department GetDepartmentById(int id);

        

        int AddDepartment(Department departmentEntity);

        int UpdateDepartment(Department departmentEntity);

        void DeleteDepartment(int deptid);

    }
}
