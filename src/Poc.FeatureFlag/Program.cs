using Poc.FeatureFlag.Options;
using Unleash;

namespace Poc.FeatureFlag;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddAuthorization();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        #region UnleashConfiguration

        var configuration = builder.Configuration;
        var unleashOptions = configuration.GetSection("UnleashOptions").Get<UnleashOptions>();

        var unleash = new DefaultUnleash(new UnleashSettings
        {
            // The URI of the Unleash server
            UnleashApi = new Uri(unleashOptions!.UnleashApi),

            // The tag of the instance
            InstanceTag = unleashOptions.InstanceTag,

            // The interval to fetch the toggles from the Unleash server
            FetchTogglesInterval = TimeSpan.FromSeconds(1) // default is 30 sec.
        });
        builder.Services.AddSingleton<IUnleash>(_ => unleash);

        #endregion

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}