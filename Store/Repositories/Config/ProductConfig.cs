 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace Repositories.Config
{
	public class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasKey(p => p.ProductId); //primary key
			builder.Property(p => p.ProductName).IsRequired();
			builder.Property(p => p.Price).IsRequired();

				builder.HasData(
				new Product() { ProductId = 1, CategoryId = 2, ImageUrl = "/images/computer.jpg", ProductName = "Computer", Price = 17_000, ShowCase = false },
				new Product() { ProductId = 2, CategoryId = 2, ImageUrl = "/images/keyboard.jpg", ProductName = "Keyboard", Price = 1_000, ShowCase = false },
				new Product() { ProductId = 3, CategoryId = 2, ImageUrl = "/images/mouse.jpg", ProductName = "Mouse", Price = 500, ShowCase = false },
				new Product() { ProductId = 4, CategoryId = 2, ImageUrl = "/images/monitor.jpg", ProductName = "Monitor", Price = 7_000, ShowCase = false },
				new Product() { ProductId = 5, CategoryId = 2, ImageUrl = "/images/deck.jpg", ProductName = "Deck", Price = 1_500, ShowCase = false },
				new Product() { ProductId = 6, CategoryId = 1, ImageUrl = "/images/history.jpg", ProductName = "History", Price = 25, ShowCase = false },
				new Product() { ProductId = 7, CategoryId = 1, ImageUrl = "/images/hamlet.jpg", ProductName = "Hamlet", Price = 45, ShowCase = false },
				new Product() { ProductId = 8, CategoryId = 1, ImageUrl = "/images/lafontaine.jpg", ProductName = "La Fontaine", Price = 75, ShowCase = true },
				new Product() { ProductId = 9, CategoryId = 2, ImageUrl = "/images/macbook.jpg", ProductName = "Macbook", Price = 30000, ShowCase = true },
				new Product() { ProductId = 10, CategoryId = 2, ImageUrl = "/images/television.jpg", ProductName = "Television", Price = 27500, ShowCase = true }
				);

			

		}
	}
}
