using System.Runtime.InteropServices.Marshalling;

namespace GenericsHW.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperClass<int>.Add(15);
            SuperClass<string>.Add("36");
            SuperClass<int>.Add(8);
            SuperClass<string>.Add("83732");
            R rObject = new R();
            SuperClass<R>.Add(rObject);

            SuperClass<int>.GetLength();
            SuperClass<string>.GetLength();
            SuperClass<R>.GetLength();

            SuperClass<int>.Show();
            SuperClass<string>.Show();
            SuperClass<R>.Show();

            SuperClass<int>.GetElementByIndex(0);
            SuperClass<string>.GetElementByIndex(0);
            SuperClass<R>.GetElementByIndex(0);

            SuperClass<int>.Remove(15);
            SuperClass<string>.Remove("36");
            SuperClass<R>.Remove(rObject);

            SuperClass<int>.Show();
            SuperClass<string>.Show();
            SuperClass<R>.Show();
        }
    }
}