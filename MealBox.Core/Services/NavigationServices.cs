using MealBox.Core.Services.Interfaces;

namespace MealBox.Core.Services
{
    public class NavigationServices : INavigationService
    {

        public async Task GoToAsync(string route)
        {
            var currentPage = Shell.Current.CurrentPage.ToString();

            if (currentPage!.EndsWith(route))
            {
                await Task.CompletedTask;
                return;
            }
            await Shell.Current.GoToAsync(route);
        }

        public async Task GoToAsync(string route, Dictionary<string, object> parameters)
        {
            await Shell.Current.GoToAsync(route, parameters);
        }

        public async Task NavigateBack()
        {
            await Shell.Current.GoToAsync("..");
        }

        public async Task NavigateBack(Dictionary<string, object> parameters)
        {
            await Shell.Current.GoToAsync("..", parameters);
        }

        public async Task NavigateBack(int numberOfLevels)
        {
            await Shell.Current.GoToAsync(string.Join("/", Enumerable.Repeat("..", numberOfLevels)));
        }
    }
}

