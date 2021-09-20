using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Financeiro.Core.Extensions
{
    public static class ObjectExtensions
    {
        #region Métodos Estáticos Públicos
        public static IList<ValidationResult> ValidadeAllProperties(this object o)
        {
            var validationResult = new List<ValidationResult>();
            var context = new ValidationContext(o, null, null);
            Validator.TryValidateObject(o, context, validationResult, true);
            return validationResult;
        }

        public static bool IsNull(this object o)
        {
            return o == null;
        }

        public static bool IsNotNull(this object o)
        {
            return o != null;
        }
        #endregion
    }
}
