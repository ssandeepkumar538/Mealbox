using System;
using Newtonsoft.Json;

namespace MealBox.Core.Models.ResponseModel
{
	public class ProductDetailsResponseModel
	{
        [JsonProperty("meals")]
        public List<ProductDetailsModel>? Meals { get; set; }
    }
}

