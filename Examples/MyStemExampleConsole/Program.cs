using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyStemSharpness.Extensions;
using MyStemSharpness.Interfaces;
using System.Diagnostics;


var configuration = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json", optional: false)
			.Build();

var services = new ServiceCollection();
services.AddFastMyStem(configuration);

var serviceProvider = services.BuildServiceProvider();



var stem = serviceProvider.GetRequiredService<IMyStem>();
IEnumerable<string> inputs = ["Двигатель башни колонки", "!!!!", "Тестовъ три", "Тестовых восемь тысяч", "Где деньги Либовский?" ];

for (int i = 0; i < 100000; i++)
{
	inputs = inputs.Append(i.ToString());
}

Stopwatch stopwatch = Stopwatch.StartNew();
foreach (var input in inputs)
{
	var result = stem.ParseAnalysis(input);
	Console.WriteLine($"{input} -> {result}");
}

stopwatch.Stop();
Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds} ms");
Console.WriteLine($"Total memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024} MB");