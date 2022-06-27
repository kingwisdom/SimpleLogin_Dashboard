namespace SimpleDashboard;

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
                fonts.AddFont("Ubuntu-Bold.ttf", "BoldFont");
                fonts.AddFont("Ubuntu-Regular.ttf", "MediumFont");
                fonts.AddFont("Ubuntu-Light.ttf", "LightFont");
                fonts.AddFont("Ubuntu-Italic.ttf", "ItalicFont");
                fonts.AddFont("materialdesignicons.ttf", "material");
            });

		return builder.Build();
	}
}
