using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum Animacy
{
	[JsonPropertyName("anim")]
	Animate,

	[JsonPropertyName("inan")]
	Inanimate
}