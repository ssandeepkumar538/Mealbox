using MealBox.ViewModels;
using MealBox.Views.BaseView;

namespace MealBox.Views;

public partial class CategoriesListView : BaseContentPage<CategoriesListViewModel>
{
    /// <summary>
    /// CategoriesListView
    /// </summary>
    /// <param name="categoriesListViewModel"></param>
    public CategoriesListView(CategoriesListViewModel categoriesListViewModel) : base(categoriesListViewModel, nameof(CategoriesListView))
	{
		InitializeComponent();
	}
}
