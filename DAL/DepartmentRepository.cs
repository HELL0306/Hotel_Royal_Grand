using Hotel_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Management_Project.DAL
{
    public class DeparmentRepository : _IDepartmentRepository

    {
        private readonly DataContext _context;

        public DeparmentRepository(DataContext context)
        {
            _context = context;
        }
        public int AddDepartment(Department departmentEntity)
        {
            int result = -1;

            if (departmentEntity != null)
            {
                _context.Departments.Add(departmentEntity);

                _context.SaveChanges();

                result = departmentEntity.Dept_id;
            }
            return result;
        }

        public void DeleteDepartment(int deptid)
        {
            Department DepartmentEntity = _context.Departments.Find(deptid);

            _context.Departments.Remove(DepartmentEntity);

            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAllDepartment()
        {
            return _context.Departments.ToList();
        }

        public Department GetDepartmentById(int id)
        {
            return _context.Departments.Find(id);
        }

        public int UpdateDepartment(Department departmentEntity)
        {
            int result = -1;

            if (departmentEntity != null)
            {

                _context.Entry(departmentEntity).State = System.Data.Entity.EntityState.Modified;

                _context.SaveChanges();

                result = departmentEntity.Dept_id;
            }
            return result;
        }
    }
    }
