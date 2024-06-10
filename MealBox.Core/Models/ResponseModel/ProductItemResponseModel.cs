using System;
using Newtonsoft.Json;

namespace MealBox.Core.Models.ResponseModel
{
	public class ProductItemResponseModel
	{
        [JsonProperty("meals")]
        public List<ProductItemModel>? Meals { get; set; }

    }
}

