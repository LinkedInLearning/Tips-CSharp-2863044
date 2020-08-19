using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace TipsConsole
{
	class Examples
	{
		public void DoWork()
		{
			// example from the Functional Patterns for C# developers 

			var currentProduct = new Product(productName: "Microphone", retailPrice: 200M);
			var salePriceA = GetProductPrice(product: currentProduct, 
																			 quantity: 12, isPremiumCustomer: true);

			var salePriceB = GetProductPriceByExpression(product: currentProduct, 
																										quantity: 12, 
																										isPremiumCustomer: true);
		}

		#region If Statements
		public decimal GetProductPrice(Product product, int quantity, bool isPremiumCustomer)
		{
			// statement version

			// note that the purpose of the if statement is to mutate the value of the discountAmount variable
			// note that the discountAmount variable is declared outside the statements
			decimal discountAmount = 0;
			if (quantity > 10)
			{
				// state mutation
				discountAmount += .15M;
			}
			if (isPremiumCustomer)
			{
				discountAmount += .05M;
			}
			return product.RetailPrice * (1 - discountAmount);

		}
		public decimal GetProductPriceByExpression(Product product, int quantity, bool isPremiumCustomer)
		{
			// The conditional operator ?:, also known as the ternary conditional operator, 
			// evaluates a Boolean expression and returns the result of one of the two expressions
			
			// expression version
			// In this version there is no mutation of variable, and also the code is more compact.
			decimal discountAmount = (quantity > 10 ? .15M : 0) + (isPremiumCustomer ? .05M : 0);
			return product.RetailPrice * (1 - discountAmount);

			// another benefit,  expressions are more composable

		}
		#endregion
	
		#region Types

	}
	public class Product
	{
		public decimal RetailPrice { get; }
		public string ProductName { get; }

		public Product(string productName, decimal retailPrice)
		{
			ProductName = productName;
			RetailPrice = retailPrice;

		}
		#endregion
	}
}
