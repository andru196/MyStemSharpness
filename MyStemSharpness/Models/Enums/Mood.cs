using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum Mood
{
	[JsonPropertyName("indc")]
	Indicative,

	[JsonPropertyName("impr")]
	Imperative
}