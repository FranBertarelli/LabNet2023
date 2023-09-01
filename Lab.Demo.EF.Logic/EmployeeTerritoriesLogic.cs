using Lab.Demo.EF.Data;
using Lab.Demo.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF.Logic
{
    public class EmployessTerritoriesLogic:BaseLogic
    {
        private readonly NorthwindContext context;


        public EmployessTerritoriesLogic()
        {
            context = new NorthwindContext();


        }
        public List<EmployeeTerritories> GetAll()
        {
            return context.EmployeeTerritories.ToList();

        }
        public void add(EmployeeTerritories NewemployeeTerritories) {
            context.EmployeeTerritories.Add(NewemployeeTerritories);

            context.SaveChanges();

        
        }
    }

}