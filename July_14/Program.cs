using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //july_14
            //1
            /*int noc, nos;
            Console.WriteLine("Enter nomber of clases ");
            noc=int.Parse(Console.ReadLine());
            string[][] stu = new string[noc][];
            for(int i = 0; i < noc; i++)
            {
                Console.WriteLine($"Enter number of students in class {i+1} ");
                nos= int.Parse(Console.ReadLine());
                stu[i] = new string[nos];
                for( int j = 0; j < nos; j++)
                {
                    Console.WriteLine($"Enter student {j+1} name");
                    stu[i][j]= Console.ReadLine();
                }
            }
            for(int i = 0;i<stu.Length;i++)
            {
                Console.WriteLine($"Studentd list of class {i+1}");
                Console.WriteLine("-----------------------------");
                for(int j = 0; j < stu[i].Length; j++)
                {
                    Console.WriteLine(stu[i][j] );
                }
                Console.WriteLine("----------------------");
            }*/
            //exercise 1
            int noe;
            Console.WriteLine("Enter number of employees : ");
            noe=int.Parse(Console.ReadLine());
            int[][] sal=new int[noe][];
            int totalsal=0;
            for(int i = 0; i < noe; i++)
            {
                sal[i] = new int[5];
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Enter employee {i+1}\'s day {j + 1} salary");
                    sal[i][j] = int.Parse(Console.ReadLine());

                }
            }
            for(int i = 0;i < noe; i++)
            {
                Console.WriteLine("Employess salary per day : ");
                Console.WriteLine("-------------------------------");
                for(int j = 0;j < 5; j++)
                {
                    Console.WriteLine($"DAY {j+1} : " + sal[i][j]);
                    totalsal = totalsal + sal[i][j];
                }
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Total salary of employee {i+1} : "+totalsal);
                Console.WriteLine("--------------------------------");
                totalsal = 0;
            }
            Console.ReadKey();
        }
    }
}
