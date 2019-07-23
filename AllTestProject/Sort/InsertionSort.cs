using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTestProject.Sort
{
    /// <summary>
    /// 插入排序
    /// </summary>
    public class InsertionSort
    {
        public static void InsertionClick(int[] dataArray)
        {
            for (int i = 1; i < dataArray.Length; i++)
            {
                int Value = dataArray[i];
                bool IsThan = false;//判断是不是下面for循环中一直没有自己能大于的数字
                //拿到i位置的元素 跟前面所有的元素进行比较
                //如果发现大的就让他往后移动
                for (int j = i-1; j >=0; j--)
                {
                    if (dataArray[j]>Value)//我从后面来的没有前面的数字大需要交换位置
                    {
                        dataArray[j + 1] = dataArray[j];//像后方移动一位
                    }
                    else
                    {
                        dataArray[j + 1] = Value;//赋值   data[j]<= IValue的时候就到data[j+1]这里占一个位置，跳出循环
                        IsThan = true;//不进入下面判断
                        break;//跳出循环
                    }
                }
                if (!IsThan)
                {
                    dataArray[0] = Value;//如果一直没进入else    就把第一个位置给他
                }
            }
            Console.WriteLine("插入排序的结果是");
            foreach (int item in dataArray)
            {
                Console.Write(item + "  ");
            }
        }
    }
}
