using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class IntervalValidator
    {
        /// <summary>
        ///     Minimal value interval can process.
        /// </summary>
        public int MinAvailableLimit { get; set; } = -99;

        /// <summary>
        ///     Maximal value interval can process.
        /// </summary>
        public int MaxAvailableLimit { get; set; } = 99;

        /// <summary>
        ///     Validates input values of graph rendering interval.
        /// </summary>
        /// <param name="MinX">String value of Minimum X.</param>
        /// <param name="MaxX">String value of Maximum X.</param>
        /// <returns>Data about validation result.</returns>
        public ValidationResult IsLimitValid(string MinX, string MaxX)
        {
            ValidationResult result = new ValidationResult
            {
                Error = "",
                IsLimimtValid = true,
                IsMinXValid = true,
                IsMaxXValid = true
            };

            //parsing
            if (!Int32.TryParse(MinX, out result.MinX))
            {
                result.IsLimimtValid = false;
                result.IsMinXValid = false;
                result.Error += "Початок інтервалу має бути заданий цілим числом " +
                    $"у діапазоні [{MinAvailableLimit}; {MaxAvailableLimit}]. ";
            }
            if (!Int32.TryParse(MaxX, out result.MaxX))
            {
                result.IsLimimtValid = false;
                result.IsMaxXValid = false;
                result.Error += "Кінець інтервалу має бути заданий цілим числом " +
                    $"у діапазоні [{MinAvailableLimit}; {MaxAvailableLimit}]. ";
            }

            //validate interval
            if(result.IsMinXValid && result.IsMaxXValid && result.MinX >= result.MaxX)
            {
                result.IsLimimtValid = false;
                result.Error = "Початок інтервалу повинен мати менше значення, ніж кінець. ";
            }

            //validate range
            if (result.MinX < MinAvailableLimit)
            {
                result.IsLimimtValid = false;
                result.Error = "Початок інтервалу має бути заданий цілим числом " +
                    $"у діапазоні [{MinAvailableLimit}; {MaxAvailableLimit}]. ";
            }
            if (result.MaxX > MaxAvailableLimit)
            {
                result.IsLimimtValid = false;
                result.Error = "Кінець інтервалу має бути заданий цілим числом " +
                    $"у діапазоні [{MinAvailableLimit}; {MaxAvailableLimit}]. ";
            }

            return result;
        }

        /// <summary>
        ///     Representation of result of validation.
        /// </summary>
        public struct ValidationResult
        {
            public bool IsLimimtValid;
            public bool IsMinXValid;
            public bool IsMaxXValid;
            public int MinX;
            public int MaxX;
            //string with description of error
            public string Error;
        }
    }
}
