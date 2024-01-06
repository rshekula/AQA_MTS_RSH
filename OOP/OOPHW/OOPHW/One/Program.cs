using System.Drawing;
using OOPHW;
using OOPHW.Figure;


// Задача 1

general[] Figures = new general[]
{
    CreateTriangle.CrTriangle(15, 15, 10), //равнобедренный треугольник
    CreateTriangle.CrTriangle(15, 15, 15), //равносторонний треугольник
    CreateTriangle.CrTriangle(10, 12, 14), //прямоугольный треугольник
    CreateTriangle.CrTriangle(20, 35, 15), //разносторонний треугольник
    new rectangle(10, 15), //прямоугольник
    new square(15) //квадрат
};

foreach (var Figure in Figures)
{
    var AreaFigure = Figure.GetArea();
    Console.WriteLine($"Фигура = {Figure.GetType()}");
    Console.WriteLine($"Площадь фигуры = {AreaFigure}");
}

