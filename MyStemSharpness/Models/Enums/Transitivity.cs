using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum Transitivity
{
	[JsonPropertyName("tran")]
	Transitive,

	[JsonPropertyName("intr")]
	Intransitive
}
