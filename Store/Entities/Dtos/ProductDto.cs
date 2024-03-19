using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Entities.Dtos
{
	public record ProductDto
	{
		//immutable olmasını istiyoruz (değiştirilemesin.init)
		public int ProductId { get; init; }
		public string? ProductName { get; init; } = string.Empty;
		public decimal Price { get; init; }
		public string? Summary { get; init; } = String.Empty;
		public string? ImageUrl { get; set; }
		public int? CategoryId { get; init; }
	}
}
