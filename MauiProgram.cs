using AntDesign.ProLayout;
using Microsoft.Extensions.Logging;

namespace MauiAppByAntDesign
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            //注入AntDesign
            builder.Services.AddAntDesign();
            builder.Services.Configure<ProSettings>(settings =>
            {
                settings.NavTheme = "light";
                settings.Layout = "side";
                settings.ContentWidth = "Fixed";
                settings.FixedHeader = false;
                settings.FixSiderbar = true;
                settings.Title = "";
                settings.PrimaryColor = "daybreak";
                settings.ColorWeak = false;
                settings.SplitMenus = false;
                settings.HeaderRender = true;
                settings.FooterRender = false;
                settings.MenuRender = true;
                settings.MenuHeaderRender = true;
                settings.HeaderHeight = 48;                                
            });


            return builder.Build();
        }
    }
}
