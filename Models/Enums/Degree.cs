using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum Degree
{
	[JsonPropertyName("comp")]
	Comparative,

	[JsonPropertyName("supr")]
	Superlative
}