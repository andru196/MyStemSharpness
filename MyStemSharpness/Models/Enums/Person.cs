using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum Person
{
	[JsonPropertyName("1per")]
	First,

	[JsonPropertyName("2per")]
	Second,

	[JsonPropertyName("3per")]
	Third
}