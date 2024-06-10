using System;
using MealBox.Core.Models.ResponseModel;

namespace MealBox.Core.Repositories.IRepo
{
	public interface IMealBoxRepository
	{
		Task<CategoryResponseModel> GetCategoryies(string Url);

        Task<ProductItemResponseModel> GetMealBoxItemList(string Url);

        Task<ProductDetailsResponseModel> GetMealBoxItemDetails(string Url);
    }
}

