using MealBox.ViewModels;
using MealBox.Views.BaseView;

namespace MealBox.Views;

/// <summary>
/// MealRecipeDetailsView - ContentPage
/// We are showing recipe details on the screen
/// </summary>
public partial class MealRecipeDetailsView : BaseContentPage<MealRecipeDetailsViewModel>
{
    /// <summary>
    ///  MealRecipeDetailsView - Constructor
    /// </summary>
    /// <param name="mealRecipeDetailsViewModel"></param>
    public MealRecipeDetailsView(MealRecipeDetailsViewModel mealRecipeDetailsViewModel): base(mealRecipeDetailsViewModel, nameof(MealRecipeDetailsView))
	{
		InitializeComponent();
	}
}
