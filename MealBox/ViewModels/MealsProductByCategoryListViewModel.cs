using System;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using MealBox.Core.Services.Interfaces;
using MealBox.ViewModels.BaseVM;
using CommunityToolkit.Mvvm.Input;
using MealBox.Core.Models;
using MealBox.Views;

namespace MealBox.ViewModels
{
    [QueryProperty(nameof(SelectedCategoryName), "SelectedCategoryName")]
	public partial class MealsProductByCategoryListViewModel : BaseViewModel
	{
        protected readonly IMealBoxServices _mealBoxServices;

        [ObservableProperty]
        ObservableCollection<ProductItemModel> productByCategoryItemList;

        [ObservableProperty]
        string selectedCategoryName;

        public MealsProductByCategoryListViewModel(INavigationService navigationService, IMealBoxServices mealBoxServices) : base(navigationService)
		{
            _mealBoxServices = mealBoxServices;
        }

        public override async Task InitializeAsync()
        {

            if (SelectedCategoryName != null)
            {
                var result = await _mealBoxServices.GetProductItemList(SelectedCategoryName);

                if (result != null)
                {
                    ProductByCategoryItemList = new ObservableCollection<ProductItemModel>(result);
                }
            }
        }


        [RelayCommand]
        public async Task SelectedProductClickAsync(ProductItemModel selectedProductItemModelObj)
        {
  
            try
            {
                if (selectedProductItemModelObj != null && selectedProductItemModelObj.idMeal >0)
                {
                    await _navigationService.GoToAsync(nameof(MealRecipeDetailsView),
                        new Dictionary<string, object>
                        {
                             {nameof(selectedProductItemModelObj.idMeal), selectedProductItemModelObj.idMeal }
                        });

                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}

