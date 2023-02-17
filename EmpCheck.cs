using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputationWithOops
{
    public class EmpCheck
    {
        
        
            public int IS_FULLTIME = 1;
            public void EmployeeCheck()
            {
                Random random = new Random();
                int EmpCheck = random.Next(2);

                if (EmpCheck == IS_FULLTIME)
                {
                    Console.WriteLine("Employee is present");
                }
                else
                {
                    Console.WriteLine("Employee is absent");
                }


            }
        }
    }

