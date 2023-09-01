using System;
using System.Collections.Generic;
using System.Linq;
using Lab.Demo.EF.Entities;
using Lab.Demo.EF.Logic;

namespace Lab.Demo.EF.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeLogic = new EmployeesLogic();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Listar empleados");
                Console.WriteLine("2. Insertar empleado");
                Console.WriteLine("3. Actualizar empleado");
                Console.WriteLine("4. Eliminar empleado");
                Console.WriteLine("q. Salir");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ListEmployees(employeeLogic);
                        break;

                    case "2":
                        InsertEmployee(employeeLogic);
                        break;

                    case "3":
                        UpdateEmployee(employeeLogic);
                        break;

                    case "4":
                        DeleteEmployee(employeeLogic);
                        break;

                    case "q":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void ListEmployees(EmployeesLogic employeeLogic)
        {
            var employees = employeeLogic.GetAll();

            Console.WriteLine("Lista de Empleados:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.EmployeeID}, Nombre: {employee.FirstName} {employee.LastName}");
                Console.WriteLine($"Título: {employee.Title}");
                Console.WriteLine($"Fecha de Nacimiento: {employee.BirthDate}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static void InsertEmployee(EmployeesLogic employeeLogic)
        {
            Console.WriteLine("Ingrese el nombre del nuevo empleado:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del nuevo empleado:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Ingrese el título del nuevo empleado:");
            string title = Console.ReadLine();
            

            var newEmployee = new Employees
            {
                FirstName = firstName,
                LastName = lastName,
                Title = title,
                
            };

            employeeLogic.InsertEmployee(newEmployee);
        }

        static void UpdateEmployee(EmployeesLogic employeeLogic)
        {
            Console.WriteLine("Ingrese el ID del empleado que desea actualizar:");
            if (int.TryParse(Console.ReadLine(), out int employeeId))
            {
                var existingEmployee = employeeLogic.GetEmployeeById(employeeId);

                if (existingEmployee != null)
                {
                    Console.WriteLine("Ingrese el nuevo nombre del empleado:");
                    string newFirstName = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo apellido del empleado:");
                    string newLastName = Console.ReadLine();
                    Console.WriteLine("Ingrese el nuevo título del empleado:");
                    string newTitle = Console.ReadLine();
                    

                    var updatedEmployee = new Employees
                    {
                        FirstName = newFirstName,
                        LastName = newLastName,
                        Title = newTitle,
                        
                    };

                    employeeLogic.UpdateEmployee(employeeId, updatedEmployee);
                }
                else
                {
                    Console.WriteLine("Empleado no encontrado.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("ID de empleado no válido.");
                Console.ReadLine();
            }
        }

        static void DeleteEmployee(EmployeesLogic employeeLogic)
        {
            Console.WriteLine("Ingrese el ID del empleado que desea eliminar:");
            if (int.TryParse(Console.ReadLine(), out int employeeId))
            {
                employeeLogic.DeleteEmployee(employeeId);
            }
            else
            {
                Console.WriteLine("ID de empleado no válido.");
                Console.ReadLine();
            }
        }
    }
}