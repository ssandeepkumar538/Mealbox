using System;
using MealBox.Core.Models;

namespace MealBox.Core.Services.Interfaces
{
	public interface IMealBoxServices
	{
		Task<List<CategoriesModel>> GetCategoriesList();

        Task<List<ProductDetailsModel>> GetProductItemDetails(long productID);

        Task<List<ProductItemModel>> GetProductItemList(string categoryNames);
    }
}

