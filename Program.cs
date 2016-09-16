using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClasses2
{
    class Program
    {
        static void Main(string[] args)
        {

            Student freshman = new Student("Brad Kilkenney", 34, "Ohio University", "Education", 3.4);
            freshman.name = "Bradley Kilkenney";
            freshman.PrintAllDetails();
            freshman.Birthday();            
            freshman.PrintAllDetails(); 

            for (int i = 0; i < 10; i++)
            {
                freshman.PrintAllDetails();
                freshman.Birthday();
            }
        }
    }
}
