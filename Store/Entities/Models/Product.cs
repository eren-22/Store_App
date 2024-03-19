using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{
    public int ProductId { get; set; }

    [Required(ErrorMessage = "Product Name is required !!")]
    public string? ProductName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Salary is required !!")]
    public decimal Price { get; set; }
    public string? Summary { get; set; } = String.Empty;
    public string? ImageUrl { get; set; }
    public int? CategoryId { get; set; }
    public Category? Category { get; set; }
    public bool ShowCase { get; set; }

}
