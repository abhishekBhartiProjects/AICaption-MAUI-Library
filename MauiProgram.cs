namespace Com.AICaptionLibrary;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.Services.AddSingleton<ICalculator, Calculator>();
        return builder.Build();
    }
}