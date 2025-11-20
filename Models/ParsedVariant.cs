using MyStemSharpness.Models.Enums;

namespace MyStemSharpness.Models;

public record ParsedVariant
{
	public string Lemma { get; init; } = string.Empty;
	public PartOfSpeech? PartOfSpeech { get; init; }
	public List<string> GrammarFeatures { get; init; } = new();
	public double Confidence { get; init; }
}