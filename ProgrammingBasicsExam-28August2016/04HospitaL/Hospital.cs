using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04HospitaL
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int treatedPatients = 0;
            int untreatedPatients = 0;
            int doctors = 7;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && untreatedPatients>treatedPatients)
                {
                    doctors++;
                }
                int patients = int.Parse(Console.ReadLine());
                if (patients <= doctors)
                {
                    treatedPatients += patients;
                }
                else
                {
                    treatedPatients += doctors;
                    untreatedPatients += (patients - doctors);
                }               
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}
