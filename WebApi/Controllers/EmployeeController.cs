using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using EF.Logic;
using EF.Entities;
using EF.MVC;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEnumerable<Employee> GetAllEmployees()
        {
            EmployeesLogic logic = new EmployeesLogic();

            List<Employee> empleados = logic.GetAll().Select(e => new Employee
            {
                Id = e.EmployeeID,
                FirstName = e.FirstName,
                LastName = e.LastName,
                Title = e.Title
            }).ToList();
            return empleados;
        }
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetEmployee(int id)
        {
            EmployeesLogic logic = new EmployeesLogic();
            var empleado = logic.GetById(id);
            if (empleado != null)
            {
                Employee empleadoModelo = new Employee
                {
                    Id = empleado.EmployeeID,
                    FirstName = empleado.FirstName,
                    LastName = empleado.LastName,
                    Title = empleado.Title
                };
                return Ok(empleadoModelo);
            }
            else
            {
                return NotFound();
            }
        }
        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteEmployee(int id)
        {
            {
                try
                {
                    EmployeesLogic logic = new EmployeesLogic();
                    var empleado = logic.GetById(id);
                    if (empleado == null) return BadRequest($"El empleado {id} no existe");
                    logic.Delete(id);
                    return Ok($"Se elimino el empleado {id}");
                }
                catch (Exception)
                {
                    return BadRequest("No se puede eliminar el empleado por conflicto de referencias");
                }

            }
        }
        [System.Web.Http.HttpPut]
        public IHttpActionResult PutEmployee(Employee empModel)
        {
            try
            {
                if (empModel == null) return BadRequest();

                EmployeesLogic logic = new EmployeesLogic();

                logic.Update(new Employees
                {
                    EmployeeID = empModel.Id,
                    FirstName = empModel.FirstName,
                    LastName = empModel.LastName,
                    Title = empModel.Title
                });
                return Ok($"El empleado {empModel.Id} fue modificado con exito");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [System.Web.Http.HttpPost]
        public IHttpActionResult PostEmployee(Employee empModel)
        {
            try
            {
                if (empModel == null) return BadRequest();

                EmployeesLogic logic = new EmployeesLogic();
                logic.Add(new EF.Entities.Employees
                {
                    FirstName = empModel.FirstName,
                    LastName = empModel.LastName,
                    Title = empModel.Title
                });
                return Ok($"Se incorporo un nuevo empleado correctamente");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}