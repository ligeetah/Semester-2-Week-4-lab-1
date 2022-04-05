using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.kl;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student("Ahmad", 123, 3.35F, 1098, 1072, "TYur", true, false, 330f);
            float merit=stu.calculate_merit();
            Console.WriteLine(merit);
            Console.WriteLine(stu.is_elegible(merit));
            Console.ReadKey();
        }
    }
}
