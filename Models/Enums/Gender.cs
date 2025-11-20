using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum Gender
{
	[JsonPropertyName("masc")]
	Masculine,

	[JsonPropertyName("femn")]
	Feminine,

	[JsonPropertyName("neut")]
	Neuter,

	[JsonPropertyName("ms-f")]
	CommonGender
}
