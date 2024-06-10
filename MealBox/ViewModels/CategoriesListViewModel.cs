using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MealBox.Core.Models;
using MealBox.Core.Services.Interfaces;
using MealBox.ViewModels.BaseVM;
using MealBox.Views;

namespace MealBox.ViewModels
{
	public partial class CategoriesListViewModel : BaseViewModel
	{
		protected readonly IMealBoxServices _mealBoxServices;

		[ObservableProperty]
		ObservableCollection<CategoriesModel> categoriesModelsList;

		public CategoriesListViewModel(INavigationService navigationService, IMealBoxServices mealBoxServices) : base(navigationService)
		{
			_mealBoxServices = mealBoxServices;
		}


        public override async Task InitializeAsync()
        {

		   var result =	await _mealBoxServices.GetCategoriesList();

			if (result != null)
			{
				CategoriesModelsList = new ObservableCollection<CategoriesModel>(result);
            }
        }


		[RelayCommand]
		public async Task SelectedCategroryClickAsync(CategoriesModel selectedCategoriesModelObj)
		{
			try
			{
                if (selectedCategoriesModelObj != null && selectedCategoriesModelObj.strCategory != null)
                {
                    await _navigationService.GoToAsync(nameof(MealsProductByCategoryListView),
                         new Dictionary<string, object>
                        {
                        {"SelectedCategoryName", selectedCategoriesModelObj.strCategory }
                        });

                }
            }
			catch (Exception ex)
			{

			}
			
		}
    }
}

