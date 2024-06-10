using System;
using System.Collections.Generic;
using MealBox.Core.Models.ResponseModel;
using MealBox.Core.Repositories.Base;
using MealBox.Core.Repositories.IRepo;
namespace MealBox.Core.Repositories
{
	public class MealBoxRepository : BaseApiRepository,  IMealBoxRepository
    {
		public MealBoxRepository()
		{
		}

        public async Task<CategoryResponseModel> GetCategoryies(string Url)
        {
            var result = new CategoryResponseModel();
            try
            {
                result = await GetAsync<CategoryResponseModel>(Url) ?? null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public async Task<ProductDetailsResponseModel> GetMealBoxItemDetails(string Url)
        {
            var result = new ProductDetailsResponseModel();
            try
            {
                result = await GetAsync<ProductDetailsResponseModel>(Url);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return result;
        }

        public async Task<ProductItemResponseModel> GetMealBoxItemList(string Url)
        {
            var result = new ProductItemResponseModel();

            try
            {
                result = await GetAsync<ProductItemResponseModel>(Url);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return result;

        }
    }
}

