using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab.Demo.EF.Logic
{
    public class EmployeesLogic : BaseLogic
    {
        public EmployeesLogic() { }

        public List<Employees> GetAll()
        {
            return _context.Employees.ToList();
        }

        public void InsertEmployee(Employees newEmployee)
        {
            
            var existingEmployee = _context.Employees.FirstOrDefault(e => e.FirstName == newEmployee.FirstName && e.LastName == newEmployee.LastName);

            if (existingEmployee != null)
            {
                Console.WriteLine("El empleado ya existe.");
            }
            else
            {
                _context.Employees.Add(newEmployee);
                _context.SaveChanges();
                Console.WriteLine("Empleado insertado exitosamente.");
            }
        }

        public void UpdateEmployee(int employeeId, Employees updatedEmployee)
        {
            var existingEmployee = _context.Employees.Find(employeeId);

            if (existingEmployee != null)
            {
                
                existingEmployee.FirstName = updatedEmployee.FirstName;
                existingEmployee.LastName = updatedEmployee.LastName;
                existingEmployee.Title = updatedEmployee.Title;
                

                _context.SaveChanges();
                Console.WriteLine("Empleado actualizado exitosamente.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            var existingEmployee = _context.Employees.Find(employeeId);

            if (existingEmployee != null)
            {
                _context.Employees.Remove(existingEmployee);
                _context.SaveChanges();
                Console.WriteLine("Empleado eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }

        public object GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }
    }
}
