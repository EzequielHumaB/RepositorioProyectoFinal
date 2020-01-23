using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectAplicada2.Data
{
    public class EmployeeServices
    {
        public bool CreateEmployee(Employee employee)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                if (contexto.Employees.Add(employee) != null)
                {
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch
            {
                throw;
            }
            return paso;
        }

    }
}
