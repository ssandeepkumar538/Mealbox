using MealBox.Views;

namespace MealBox;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(CategoriesListView), typeof(CategoriesListView));
        Routing.RegisterRoute(nameof(MealsProductByCategoryListView), typeof(MealsProductByCategoryListView));
        Routing.RegisterRoute(nameof(MealRecipeDetailsView), typeof(MealRecipeDetailsView));
    }
}

