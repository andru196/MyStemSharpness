using System.Text.Json.Serialization;

namespace MyStemSharpness.Models;

public record WordAnalysis
{
	[JsonPropertyName("lex")]
	public string? Lemma { get; init; }

	[JsonPropertyName("gr")]
	public string? RawGrammar { get; init; }

	[JsonPropertyName("wt")]
	public double? Weight { get; init; }

	[JsonPropertyName("qual")]
	public string? Quality { get; init; }

	// Разобранные грамматические характеристики
	[JsonIgnore]
	public GrammarAnalysis? Grammar => ParseGrammar(RawGrammar);

	private static GrammarAnalysis? ParseGrammar(string? rawGrammar)
	{
		if (string.IsNullOrEmpty(rawGrammar))
			return null;

		// Здесь можно реализовать парсинг строки грамматики
		// MyStem возвращает грамматику в формате "S,femn,sing,nomn"
		return new GrammarAnalysis();
	}
}
