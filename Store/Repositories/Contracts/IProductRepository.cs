﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Entities.RequestParameters;

namespace Repositories.Contracts
{
	public interface IProductRepository : IRepositoryBase<Product>
	{
		IQueryable<Product> GetAllProducts(bool trackChanges);
		IQueryable<Product> GetAllProductsWithDetails(ProductRequestParameters p);
		IQueryable<Product> GetShowcaseProducts(bool trackChanges);
		public Product? GetOneProduct(int id, bool trackChanges);
		void CreateOneProduct(Product product);
		void DeleteOneproduct(Product product);
		void UpdateOneProduct(Product entity);
	}
}
