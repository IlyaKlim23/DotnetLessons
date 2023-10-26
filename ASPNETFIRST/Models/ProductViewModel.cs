using System.Runtime.InteropServices.JavaScript;

namespace ASPNETFIRST.Models;

public class ProductViewModel
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public long Price { get; set; }

    public string Description { get; set; }
}