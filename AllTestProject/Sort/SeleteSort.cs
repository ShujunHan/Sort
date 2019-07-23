using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTestProject.Sort
{
    /// <summary>
    /// 选择排序  
    /// </summary>
    public class SeleteSort
    {    
        public static void SeleteSortArray(int[] ArrayList)
        {
            for (int i = 0; i < ArrayList.Length-1; i++)
            {
                int value = ArrayList[i];//当前的值
                int valueIndex = i;
                for (int j = i+1; j < ArrayList.Length; j++)
                {
                    if (ArrayList[j]<value)
                    {
                        value = ArrayList[j];
                        valueIndex = j;//for循环J中找到最小的值
                    }
                }
                if (valueIndex != i)//最小的开始赋值
                {
                    ArrayList[valueIndex] = ArrayList[valueIndex] + ArrayList[i];
                    ArrayList[i] = ArrayList[valueIndex] - ArrayList[i];
                    ArrayList[valueIndex] = ArrayList[valueIndex] - ArrayList[i];
                }
            }
            Console.WriteLine("选择排序的结果是");
            foreach (int item in ArrayList)
            {
                Console.Write(item + " ");
            }
        }
    }
}
