using System.Text.Json.Serialization;

namespace MyStemSharpness.Models.Enums;

public enum PartOfSpeech
{
	[JsonPropertyName("A")]
	Adjective,

	[JsonPropertyName("ADV")]
	Adverb,

	[JsonPropertyName("ADVPRO")]
	PronominalAdverb,

	[JsonPropertyName("ANUM")]
	NumeralAdjective,

	[JsonPropertyName("APRO")]
	PronominalAdjective,

	[JsonPropertyName("COM")]
	PartOfCompound,

	[JsonPropertyName("CONJ")]
	Conjunction,

	[JsonPropertyName("INTJ")]
	Interjection,

	[JsonPropertyName("NUM")]
	Numeral,

	[JsonPropertyName("PART")]
	Particle,

	[JsonPropertyName("PR")]
	Preposition,

	[JsonPropertyName("S")]
	Noun,

	[JsonPropertyName("SPRO")]
	PronounNoun,

	[JsonPropertyName("V")]
	Verb
}
