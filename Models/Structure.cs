namespace RDUModels.Models;

public class Structure
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Unit { get; set; }
    public List<Item> Items { get; set; }
    public double Price { get; set; }
}