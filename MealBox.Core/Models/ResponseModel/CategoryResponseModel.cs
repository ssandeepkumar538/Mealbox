using System;
using Newtonsoft.Json;

namespace MealBox.Core.Models.ResponseModel
{
	public class CategoryResponseModel
	{
        [JsonProperty("categories")]
        public List<CategoriesModel>? Categories { get; set; }
    }
}

