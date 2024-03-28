using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHW.Task2
{
    internal class SuperClass<T>
    {
        private static T[]? s_sclass = { };

        internal static T[] Add(T obj)
        {
            Array.Resize(ref s_sclass, s_sclass.GetLength(0) + 1);
            s_sclass[s_sclass.GetLength(0) - 1] = obj;
            return s_sclass;
        }

        public static T[] Remove(T obj)
        {
            if (s_sclass.Contains(obj))
            {
                T[] tmpArray = s_sclass.Except(new T[] { obj }).ToArray();
                Array.Resize(ref s_sclass, s_sclass.GetLength(0) - 1);
                Array.Copy(tmpArray, s_sclass, s_sclass.GetLength(0));
                return s_sclass;
            }
            else
            {
                Console.WriteLine($"{obj} нет в массиве");
                throw new Exception();
            }
        }

        public static T? GetElementByIndex(int index)
        {
            try
            {
                return s_sclass[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                throw new IndexOutOfRangeException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }
        }

        public static int GetLength()
        {
            return s_sclass.GetLength(0);
        }

        public static void Show()
        {
            if (s_sclass.GetLength(0) != 0)
            {
                for (int i = 0; i <= s_sclass.GetUpperBound(0); i++)
                {
                    Console.Write($"{s_sclass[i]} ");
                }
            }
            else Console.Write($"Массив пустой");
            Console.WriteLine();
        }
    }
}