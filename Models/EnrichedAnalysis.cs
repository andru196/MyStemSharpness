namespace MyStemSharpness.Models;

public record EnrichedAnalysis
{
	public string OriginalText { get; init; } = string.Empty;
	public List<ParsedVariant> Variants { get; init; } = new();
	public bool HasAnalysis => Variants.Count > 0;
}