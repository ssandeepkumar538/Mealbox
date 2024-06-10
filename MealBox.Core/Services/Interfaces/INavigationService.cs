using System;
namespace MealBox.Core.Services.Interfaces
{
	public interface INavigationService
    {
        Task GoToAsync(string route);

        Task GoToAsync(string route, Dictionary<string, object> parameters);

        Task NavigateBack();

        Task NavigateBack(Dictionary<string, object> parameters);

        Task NavigateBack(int numberOfLevels);

    }
}

