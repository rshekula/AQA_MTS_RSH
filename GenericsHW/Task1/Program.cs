namespace GenericsHW.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point<int> point1 = new(3, 16);
            Point<float> point2 = new(24.5f, 43.0f);
            Point<double> point3 = new(3.6, 4.7);

            point1.Show();
            point2.Show();
            point3.Show();
        }
    }
}