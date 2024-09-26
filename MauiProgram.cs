using Microsoft.Extensions.Logging;

namespace sample_hybrid_web_view;

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

#if MACCATALYST
		// https://github.com/dotnet/maui/issues/23390#issuecomment-2202295194
		var handlerType = typeof(Microsoft.Maui.Handlers.HybridWebViewHandler);
		var field = handlerType.GetField("AppOriginUri",
			System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic
		) ?? throw new Exception("AppOriginUri field not found");
		field.SetValue(null, new Uri("app://localhost/"));
#endif

		return builder.Build();
	}
}
