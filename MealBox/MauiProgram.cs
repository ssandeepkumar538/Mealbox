using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using MealBox.Core.Services.Interfaces;
using MealBox.Core.Services;
using MealBox.Core.Repositories.IRepo;
using MealBox.Core.Repositories;
using MealBox.Views;
using MealBox.ViewModels;

namespace MealBox;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<INavigationService, NavigationServices>();
		builder.Services.AddSingleton<IMealBoxServices, MealBoxServices>();
		builder.Services.AddSingleton<IMealBoxRepository, MealBoxRepository>();

		//View
		builder.Services.AddSingleton<CategoriesListView>();
		builder.Services.AddSingleton<MealsProductByCategoryListView>();
        builder.Services.AddSingleton<MealRecipeDetailsView>();
        

        //ViewModel
        builder.Services.AddSingleton<CategoriesListViewModel>();
        builder.Services.AddSingleton<MealsProductByCategoryListViewModel>();
        builder.Services.AddSingleton<MealRecipeDetailsViewModel>();


        return builder.Build();
	}
}

