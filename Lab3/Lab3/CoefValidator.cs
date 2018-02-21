using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class CoefValidator
    {
        /// <summary>
        ///     Minimal coef value.
        /// </summary>
        public float MinAvailableLimit { get; set; } = -float.MaxValue;

        /// <summary>
        ///     Maximal coef value.
        /// </summary>
        public float MaxAvailableLimit { get; set; } = float.MaxValue;

        public string Name { get; set; } = "Коефіцієнт";

        /// <summary>
        ///     Validates input values of graph rendering interval.
        /// </summary>
        /// <param name="MinX">String value of Minimum X.</param>
        /// <param name="MaxX">String value of Maximum X.</param>
        /// <returns>Data about validation result.</returns>
        public ValidationResult IsCoefValid(string coef)
        {
            ValidationResult result = new ValidationResult
            {
                Error = "",
                IsCoefValid = true
            };

            //uniform numeric culture
            if (CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator == ".")
                coef = coef.Replace(',', '.');
            else
                coef = coef.Replace('.', ',');
            //parsing
            if (!float.TryParse(coef, out result.Coef))
            {
                result.IsCoefValid = false;
                result.Error = $"{Name} має бути заданий дійсним числом " +
                    $"у діапазоні [{MinAvailableLimit}; {MaxAvailableLimit}]. ";
            }

            //validate range
            if (result.Coef < MinAvailableLimit || result.Coef > MaxAvailableLimit)
            {
                result.IsCoefValid = false;
                result.Error = $"{Name} має бути заданий дійсним числом " +
                    $"у діапазоні [{MinAvailableLimit}; {MaxAvailableLimit}]. ";
            }
            return result;
        }

        /// <summary>
        ///     Representation of result of validation.
        /// </summary>
        public struct ValidationResult
        {
            public bool IsCoefValid;
            public float Coef;
            //string with description of error
            public string Error;
        }
    }
}
