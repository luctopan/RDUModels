using RDUModels.Models;

Console.WriteLine("RDUSystem");
var item1 = new Item
{
    Id = 1,
    Name = "Abraçadeira",
    Unit = "cm",
    CostValue = 1.99,
    SaleValue = 2.84
};

var item2 = new Item
{
    Id = 2,
    Name = "Porca",
    Unit = "pç",
    CostValue = 0.99,
    SaleValue = 1.21
};

var struct1 = new Structure
{
    Id = 029,
    Name = "Estrutura elétrica",
    Unit = "peça",
    Items = new List<Item> { item1, item2 },
    Price = 1920.40
};