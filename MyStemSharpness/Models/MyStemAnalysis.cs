using System.Text.Json.Serialization;

namespace MyStemSharpness.Models;

public record MyStemAnalysis
{
	[JsonPropertyName("text")]
	public List<TextAnalysis> TextAnalysis { get; init; } = new();

	[JsonPropertyName("error")]
	public string? Error { get; init; }

	[JsonPropertyName("version")]
	public string? Version { get; init; }
}