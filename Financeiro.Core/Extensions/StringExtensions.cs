
using System.Globalization;
using System.Text;

namespace Financeiro.Core.Extensions
{
    public static class StringExtensions
    {
        #region Métodos Estáticos Públicos
        public static bool IsNullOrEmpty(this string s)
        {
            return s == null || s == string.Empty;
        }

        public static string ToStringOrEmpty(this string s)
        {
            return s == null ? string.Empty : s;
        }

        public static string RemoveDiacritics(this string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        #endregion
    }
}
