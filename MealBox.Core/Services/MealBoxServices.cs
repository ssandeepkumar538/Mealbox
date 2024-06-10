using MealBox.Core.Models;
using MealBox.Core.Repositories.IRepo;
using MealBox.Core.Services.Interfaces;

namespace MealBox.Core.Services
{
	public class MealBoxServices : IMealBoxServices
	{
        private readonly IMealBoxRepository _mealBoxRepository;

		public MealBoxServices(IMealBoxRepository mealBoxRepository)
		{
			_mealBoxRepository = mealBoxRepository;
        }

        public async Task<List<CategoriesModel>> GetCategoriesList()
        {
            try
            {
                var result = await _mealBoxRepository.GetCategoryies("https://www.themealdb.com/api/json/v1/1/categories.php");

                return result?.Categories ?? null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

        public async Task<List<ProductDetailsModel>> GetProductItemDetails(long productID)
        {
            try
            {
                var result = await _mealBoxRepository.GetMealBoxItemDetails($"https://www.themealdb.com/api/json/v1/1/lookup.php?i={productID}");

                return result?.Meals ?? null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
  
        }

        public async Task<List<ProductItemModel>> GetProductItemList(string categoryName)
        {
            try
            {
                var result = await _mealBoxRepository.GetMealBoxItemList($"https://www.themealdb.com/api/json/v1/1/filter.php?c={categoryName}");

                return result?.Meals ?? null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }
    }
}

