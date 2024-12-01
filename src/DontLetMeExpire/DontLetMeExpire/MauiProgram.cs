using DontLetMeExpire.Services;
using DontLetMeExpire.ViewModels;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace DontLetMeExpire
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<IItemService, DummyItemService>();
            builder.Services.AddSingleton<IStorageLocationService, DummyStorageLocationService>();

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<MainPage>();
            return builder.Build();
        }
    }
}
