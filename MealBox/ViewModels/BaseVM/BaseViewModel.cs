using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MealBox.Core.Services.Interfaces;

namespace MealBox.ViewModels.BaseVM
{
    public partial class BaseViewModel : ObservableObject, IQueryAttributable
    {
        protected readonly INavigationService _navigationService;

        #region Properties


        [ObservableProperty]
        bool _isProcessing;

        /// <summary>
        /// IsConnected
        /// </summary>
        public bool IsConnected
        {
            get
            {
                return Connectivity.NetworkAccess == NetworkAccess.Internet;
            }
        }

        #endregion


        /// <summary>
        /// BaseViewModel - Constructor
        /// </summary>
        /// <param name="navigationService"></param>
        public BaseViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }


        /// <summary>
        /// ApplyQueryAttributes
        /// </summary>
        /// <param name="query"></param>
        public virtual void ApplyQueryAttributes(IDictionary<string, object> query)
        {
        }


        /// <summary>
        /// InitializeAsync
        /// </summary>
        /// <returns></returns>
        public virtual Task InitializeAsync()
        {
            return Task.CompletedTask;
        }


        /// <summary>
        /// Clear
        /// </summary>
        /// <returns></returns>
        public virtual Task Clear()
        {
            return Task.CompletedTask;
        }


        /// <summary>
        /// NavigateToBackPage
        /// </summary>
        [RelayCommand]
        protected virtual async Task NavigateToBackPageAsync()
        {
           await _navigationService.NavigateBack();
        }
    }
}

