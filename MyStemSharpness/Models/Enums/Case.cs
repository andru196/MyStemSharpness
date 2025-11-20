using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum Case
{
	[JsonPropertyName("nomn")]
	Nominative,

	[JsonPropertyName("gent")]
	Genitive,

	[JsonPropertyName("datv")]
	Dative,

	[JsonPropertyName("accs")]
	Accusative,

	[JsonPropertyName("ablt")]
	Instrumental,

	[JsonPropertyName("loct")]
	Prepositional,

	[JsonPropertyName("voct")]
	Vocative,

	[JsonPropertyName("gen1")]
	FirstGenitive,

	[JsonPropertyName("gen2")]
	SecondGenitive,

	[JsonPropertyName("acc2")]
	SecondAccusative,

	[JsonPropertyName("loc1")]
	FirstPrepositional,

	[JsonPropertyName("loc2")]
	SecondPrepositional
}