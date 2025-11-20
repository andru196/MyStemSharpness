using System.Text.Json.Serialization;

namespace MyStemSharpness.Models;

public record MyStemBatchResult
{
	[JsonPropertyName("result")]
	public List<MyStemWordResult> Result { get; init; } = new();

	[JsonPropertyName("error")]
	public string? Error { get; init; }
}