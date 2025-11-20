using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using MyStemSharpness.Configuration;
using MyStemSharpness.Implementations;
using MyStemSharpness.Interfaces;

namespace MyStemSharpness.Extensions;

public static class DependencyInjection
{

	public static IServiceCollection AddMyStemOptions(
		this IServiceCollection services, IConfiguration configuration)
	{
		services.AddOptions<MyStemOptions>()
				.Bind(configuration.GetSection(nameof(MyStemOptions)));
		return services;
	}

	public static IServiceCollection AddMyStem(
		this IServiceCollection services, IConfiguration configuration)
	{
		services.AddScoped<IMyStem, MyStem>();

		services.AddMyStemOptions(configuration);
		return services;
	}

	public static IServiceCollection AddMyStem(
		this IServiceCollection services, MyStemOptions options)
	{
		services.AddScoped<IMyStem, MyStem>();

		services.AddSingleton(Options.Create(options));

		return services;
	}


	public static IServiceCollection AddFastMyStem(
		this IServiceCollection services, IConfiguration configuration)
	{
		services.AddScoped<IMyStem, FastMyStem>();

		services.AddMyStemOptions(configuration);
		return services;
	}


	public static IServiceCollection AddFastMyStem(
		this IServiceCollection services, MyStemOptions options)
	{
		services.AddScoped<IMyStem, FastMyStem>();

		services.AddSingleton(Options.Create(options));
		
		return services;
	}
}
