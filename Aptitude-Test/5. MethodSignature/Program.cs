using System;
using System.Threading.Tasks;

namespace MethodSignature
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The Method Signature for SomeCalculation looks like as shown below");            
        }        
                      
        //Required Method Signature
        public async Task<(long averageSalary, int numberOfEmployee)> SomeCalculation(long totalSalary, int headcount, bool value)
        {
            // Do some calculations 
            return (totalSalary,headcount);
        }

       
    }

   
  
}
