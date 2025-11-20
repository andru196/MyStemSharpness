using System.Text.Json.Serialization;

namespace MyStemSharpness.Models;

public record TextAnalysis
{
	[JsonPropertyName("text")]
	public string Text { get; init; } = string.Empty;

	[JsonPropertyName("analysis")]
	public List<WordAnalysis> Analysis { get; init; } = new();
}
