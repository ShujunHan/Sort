using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllTestProject.Sort;
namespace AllTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] InsertionArray = new int[] { 1, 2, 5, 4, 3, 9, 7, 8, 10, 25, 21, 30 };
            InsertionSort.InsertionClick(InsertionArray);
            Console.WriteLine("");
            Console.WriteLine("请输入任意键");
            Console.ReadLine();
            SeleteSort.SeleteSortArray(InsertionArray);
            Console.Read();
        }
    }
}
