using System;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using MealBox.Core.Services.Interfaces;
using MealBox.ViewModels.BaseVM;
using MealBox.Core.Models;
using CommunityToolkit.Mvvm.Input;

namespace MealBox.ViewModels
{
    [QueryProperty(nameof(SelectedMealId), "idMeal")]
    public partial class MealRecipeDetailsViewModel : BaseViewModel
	{
        protected readonly IMealBoxServices _mealBoxServices;

        [ObservableProperty]
        ProductDetailsModel productDetailsByMealIDItem;

        [ObservableProperty]
        long selectedMealId;


        public MealRecipeDetailsViewModel(INavigationService navigationService, IMealBoxServices mealBoxServices) : base(navigationService)
		{
            _mealBoxServices = mealBoxServices;
        }

        public override async Task InitializeAsync()
        {

            if (SelectedMealId>0)
            {
                var result = await _mealBoxServices.GetProductItemDetails(SelectedMealId);

                if (result != null)
                {
                    ProductDetailsByMealIDItem = result.FirstOrDefault()?? new ProductDetailsModel() ;
                }
            }
        }

        protected override async Task NavigateToBackPageAsync()
        {
            try
            {
                var parameters = new Dictionary<string, object> {
                            { "SelectedCategoryName", ProductDetailsByMealIDItem.strCategory },
                        };
                await _navigationService.NavigateBack(parameters);
            }
            catch (Exception ex)
            {
            }
        }

        [RelayCommand]
        public async Task NavigateToBackTestAsync()
        {
            try
            {
                await _navigationService.NavigateBack(1);
            }
            catch (Exception ex)
            {
            }
        }
    }
}

