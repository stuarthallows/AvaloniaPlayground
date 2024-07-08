using AvaloniaApp.Services;
using AvaloniaApp.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace AvaloniaApp.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddServices(this IServiceCollection collection) 
    {
        collection.AddTransient<IProductsService, ProductsService>();

        collection.AddTransient<ButtonsPageViewModel>();
        collection.AddTransient<GridPageViewModel>();
        collection.AddTransient<HomePageViewModel>();
        collection.AddTransient<ImagePageViewModel>();
        collection.AddTransient<MainWindowViewModel>();
    }
}