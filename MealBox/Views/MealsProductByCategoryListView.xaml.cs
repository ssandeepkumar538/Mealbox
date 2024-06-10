using MealBox.ViewModels;
using MealBox.Views.BaseView;

namespace MealBox.Views;

/// <summary>
/// MealsProductByCategoryListView
/// </summary>
public partial class MealsProductByCategoryListView : BaseContentPage<MealsProductByCategoryListViewModel>
{
    /// <summary>
    /// MealsProductByCategoryListView - Constructor
    /// </summary>
    /// <param name="mealsProductByCategoryListViewModel"></param>
    public MealsProductByCategoryListView(MealsProductByCategoryListViewModel mealsProductByCategoryListViewModel) : base(mealsProductByCategoryListViewModel, nameof(MealsProductByCategoryListView))
	{
		InitializeComponent();
	}
}
