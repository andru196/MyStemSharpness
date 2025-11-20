using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum Tense
{
	[JsonPropertyName("pres")]
	Present,

	[JsonPropertyName("past")]
	Past,

	[JsonPropertyName("futr")]
	Future
}
