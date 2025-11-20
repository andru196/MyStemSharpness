using MyStemSharpness.Interfaces;
using MyStemSharpness.Models;
using System.Text.Json;

namespace MyStemSharpness.Extensions;

public static class MyStemExtension
{
	private static JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true
        };
public static List<MyStemWordResult> ParseAnalysis(this IMyStem myStem, string text)
	{
		var end = myStem.Options.Value.EndString.Trim();

		for (var i = 0; i < 3; i++)
		{
			try
			{
				var json = myStem.Analysis(text);
				var lines = json.Split("\n");
				if (lines.Length == 1)
					return JsonSerializer.Deserialize<List<MyStemWordResult>>(lines[0], _jsonOptions);
				if (lines.Length == 2)
					return JsonSerializer.Deserialize<List<MyStemWordResult>>(lines[0], _jsonOptions);
				if (lines.Length == 3)
					return JsonSerializer.Deserialize<List<MyStemWordResult>>(lines[1], _jsonOptions);
			}
			catch{}
		}
		return null;

	}
}
