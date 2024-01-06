using AbstractInterfaces.OneFigures;
using AbstractInterfaces.Two;

// Задание 1
double pGeneral = 0;
double sGeneral = 0;

Figure[] figures = new Figure[]
{
    new Circle(10),
    new Rectangle(15, 25),
    new Triangle(10, 12, 15)
};

foreach (var figure in figures)
{
    figure.PrintInfo();
    Console.WriteLine($"Площадь фигуры = {Math.Round(figure.GetArea(), 2)}, периметр фигуры = {Math.Round(figure.GetPerimeter(), 2)}");
    pGeneral += figure.GetPerimeter();
    sGeneral += figure.GetArea();
}

Console.WriteLine($"\nПлощадь всех фигур = {Math.Round(sGeneral, 2)}, периметр всех фигур = {Math.Round(pGeneral, 2)}");



// Задание 2
var productsBase = new List<Base>();

productsBase.AddRange(new Base[]
{
    new Product("Хлеб", 50, new DateOnly(2023, 12, 05), new DateOnly(2023, 12, 15)),
    new Product("Чай", 200, new DateOnly(2023, 11, 01), new DateOnly(2024, 11, 01)),
    new Product("Вода", 35, new DateOnly(2023, 12, 20), new DateOnly(2024, 02, 20)),

    new Batch(new List<Product>()
    {
        new Product("Чипсы", 45, new DateOnly(2023, 11, 15), new DateOnly(2024, 05, 15)),
        new Product("Чипсы", 45, new DateOnly(2023, 11, 15), new DateOnly(2024, 05, 15)),
        new Product("Чипсы", 45, new DateOnly(2023, 11, 15), new DateOnly(2024, 05, 15))
    }),

    new Set("Детский", new List<Product>()
    {
        new Product("Мармелад", 35, new DateOnly(2023, 11, 01), new DateOnly(2024, 05, 01)),
        new Product("Печенье", 40, new DateOnly(2023, 12, 15), new DateOnly(2024, 05, 15)),
        new Product("Яблочный сок", 60, new DateOnly(2023, 12, 20), new DateOnly(2024, 02, 20))
    })
});

foreach (var product in productsBase)
{
    product.PrintProductInfo();
}

foreach (var product in productsBase)
{
    if (product.IsExpired())
    {
        Console.Write("Продукт просрочен");
        product.PrintProductInfo();
    }
}