using MyStemSharpness.Models.Enums;
using System.Text.Json.Serialization;

namespace MyStemSharpness.Models;

public record GrammarAnalysis
{
	[JsonPropertyName("pos")]
	public PartOfSpeech? PartOfSpeech { get; init; }

	[JsonPropertyName("gender")]
	public Gender? Gender { get; init; }

	[JsonPropertyName("number")]
	public Number? Number { get; init; }

	[JsonPropertyName("case")]
	public Case? Case { get; init; }

	[JsonPropertyName("tense")]
	public Tense? Tense { get; init; }

	[JsonPropertyName("voice")]
	public Voice? Voice { get; init; }

	[JsonPropertyName("mood")]
	public Mood? Mood { get; init; }

	[JsonPropertyName("aspect")]
	public Aspect? Aspect { get; init; }

	[JsonPropertyName("animacy")]
	public Animacy? Animacy { get; init; }

	[JsonPropertyName("person")]
	public Person? Person { get; init; }

	[JsonPropertyName("degree")]
	public Degree? Degree { get; init; }

	[JsonPropertyName("transitivity")]
	public Transitivity? Transitivity { get; init; }

	// Дополнительные поля, которые могут присутствовать
	[JsonPropertyName("invl")]
	public bool? Involved { get; init; }

	[JsonPropertyName("RO")]
	public string? Root { get; init; }
}

