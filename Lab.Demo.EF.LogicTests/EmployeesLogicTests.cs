using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.Demo.EF.Logic;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;

namespace Lab.Demo.EF.Logic.Tests
{
    [TestClass()]
    public class EmployeesLogicTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            // Arrange
            var employeeLogic = new EmployeesLogic();

            // Act
            List<Employees> employees = employeeLogic.GetAll();

            // Assert
            Assert.IsNotNull(employees); 
            Assert.IsTrue(employees.Count > 0); 
        }

        [TestMethod()]
        public void InsertEmployeeTest()
        {
            // Arrange
            var employeeLogic = new EmployeesLogic();
            Employees newEmployee = new Employees
            {
                FirstName = "John",
                LastName = "Doe",
                Title = "Developer",
                BirthDate = new DateTime(1985, 1, 15)
            };

            // Act
            employeeLogic.InsertEmployee(newEmployee);

            // Assert
            Employees retrievedEmployee = employeeLogic.GetEmployeeById(newEmployee.EmployeeID);
            Assert.IsNotNull(retrievedEmployee); // 
            Assert.AreEqual(newEmployee.FirstName, retrievedEmployee.FirstName); 
            Assert.AreEqual(newEmployee.LastName, retrievedEmployee.LastName);
            Assert.AreEqual(newEmployee.Title, retrievedEmployee.Title);
            Assert.AreEqual(newEmployee.BirthDate, retrievedEmployee.BirthDate);
        }

        [TestMethod()]
        public void UpdateEmployeeTest()
        {
            // Arrange
            var employeeLogic = new EmployeesLogic();
            Employees existingEmployee = employeeLogic.GetEmployeeById(1); 
            string updatedTitle = "Senior Developer";

            // Act
            existingEmployee.Title = updatedTitle;
            employeeLogic.UpdateEmployee(existingEmployee);

            // Assert
            Employees updatedEmployee = employeeLogic.GetEmployeeById(1);
            Assert.IsNotNull(updatedEmployee);
            Assert.AreEqual(updatedTitle, updatedEmployee.Title); 
        }

        [TestMethod()]
        public void DeleteEmployeeTest()
        {
            // Arrange
            var employeeLogic = new EmployeesLogic();
            Employees employeeToDelete = employeeLogic.GetEmployeeById(2); 

            // Act
            employeeLogic.DeleteEmployee(employeeToDelete);

            // Assert
            Employees deletedEmployee = employeeLogic.GetEmployeeById(2);
            Assert.IsNull(deletedEmployee); 
        }

        [TestMethod()]
        public void GetEmployeeByIdTest()
        {
            // Arrange
            var employeeLogic = new EmployeesLogic();
            int employeeIdToRetrieve = 3; 

            // Act
            EmployeesLogic retrievedEmployee = employeeLogic.GetEmployeeById(employeeIdToRetrieve);

            // Assert
            Assert.IsNotNull(retrievedEmployee); 
            Assert.AreEqual(employeeIdToRetrieve, retrievedEmployee.EmployeeID); 
        }
    }
}