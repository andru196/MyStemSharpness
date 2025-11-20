using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum Aspect
{
	[JsonPropertyName("perf")]
	Perfective,

	[JsonPropertyName("impf")]
	Imperfective
}