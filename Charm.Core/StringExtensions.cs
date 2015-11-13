using System.Text.RegularExpressions;

namespace Charm.Core
{
    public static class StringExtensions
    {
        /// <summary>
        /// Breaks a camel or Pascal cased string apart with space separation and lower case words.
        /// </summary>
        /// <param name="str">The string to apply sentence case to.</param>
        /// <returns>The same string with spaces and lower case letters where camel case used to exist.</returns>
        public static string ToSentenceCase(this string str)
        {
            return Regex.Replace(str, "[a-z][A-Z]", m => m.Value[0] + " " + char.ToLower(m.Value[1]));
        }

        /// <summary>
        /// Breaks a camel or Pascal cased string apart with space separation and upper case words.
        /// </summary>
        /// <param name="str">The string to apply proper case to.</param>
        /// <returns>The same string with spaces and upper case letters where camel case used to exist.</returns>
        public static string ToProperCase(this string str)
        {
            return Regex.Replace(str, "[a-z][A-Z]", m => m.Value[0] + " " + char.ToUpper(m.Value[1]));
        }
    }
}
