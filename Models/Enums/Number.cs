using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum Number
{
	[JsonPropertyName("sing")]
	Singular,

	[JsonPropertyName("plur")]
	Plural
}
