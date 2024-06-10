using System;
using MealBox.ViewModels;
using MealBox.ViewModels.BaseVM;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace MealBox.Views.BaseView
{
    /// <summary>
    /// BaseContentPage - This is base content page which can inherit for views which has contentpage
    /// </summary>
    /// <typeparam name="TViewModel"></typeparam>
    public abstract partial class BaseContentPage<TViewModel> : ContentPage where TViewModel : BaseViewModel
    {
        /// <summary>
        /// BaseContentPage - Constructor
        /// </summary>
        /// <param name="viewModel"></param>
        /// <param name="pageTitle"></param>
        public BaseContentPage(TViewModel viewModel, string pageTitle)
        {
            BindingContext = ViewModel = viewModel;
            Title = pageTitle;
            On<iOS>().SetUseSafeArea(true);
            Shell.SetNavBarIsVisible(this, false);
            Shell.SetTabBarIsVisible(this, false);
        }

        /// <summary>
        /// OnAppearing
        /// </summary>
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await ViewModel.InitializeAsync();
        }

        /// <summary>
        /// OnDisappearing
        /// </summary>
        protected async override void OnDisappearing()
        {
            await ViewModel.Clear();
            base.OnDisappearing();
        }

        /// <summary>
        /// OnNavigatedTo
        /// </summary>
        /// <param name="args"></param>
        protected override async void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);
        }

        /// <summary>
        /// ViewModel - Refer this property in all views.
        /// </summary>
        protected TViewModel ViewModel { get; }
    }
}
