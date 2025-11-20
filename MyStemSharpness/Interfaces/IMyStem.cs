using Microsoft.Extensions.Options;
using MyStemSharpness.Configuration;

namespace MyStemSharpness.Interfaces;

public interface IMyStem: IDisposable
{
	/// <summary>
	/// Analyzes the given text using the MyStem executable in a single-threaded manner.
	/// </summary>
	/// <param name="text">The text to analyze.</param>
	/// <returns>The analysis result from MyStem.</returns>
	/// <exception cref="FileNotFoundException">If the MyStem executable is not found at the specified path.</exception>
	/// <exception cref="FormatException">If an error occurs during the MyStem analysis.</exception>
	string Analysis(string text);

	internal IOptions<MyStemOptions> Options { get; }
}
