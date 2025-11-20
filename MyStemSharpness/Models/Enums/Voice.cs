using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum Voice
{
	[JsonPropertyName("actv")]
	Active,

	[JsonPropertyName("pssv")]
	Passive
}
