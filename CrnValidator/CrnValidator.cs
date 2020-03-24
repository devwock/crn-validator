using System;
using System.Linq;

namespace CrnValidator
{
    public class CrnValidator
    {
        private static readonly int[] crnCheckId = { 1, 3, 7, 1, 3, 7, 1, 3, 5 };

        public bool IsValidCrn(string crn)
        {
            if (string.IsNullOrWhiteSpace(crn))
            {
                return false;
            }

            crn = crn.Replace("-", "").Replace(" ", "");

            if (crn.Length != 10)
            {
                return false;
            }

            if (!crn.All(c => (c >= 48 && c <= 57)))
            {
                return false;
            }

            int[] crnNumber = crn.Select(c => c - '0').ToArray();

            int checkSum = 0;
            for (int i = 0; i < 9; i++)
            {
                checkSum += crnCheckId[i] * crnNumber[i];
            }

            int checkSum2 = Convert.ToInt32(Math.Floor(Convert.ToDecimal(crnNumber[8] * crnCheckId[8]) / 10));
            checkSum += checkSum2;

            var result = 10 - (checkSum % 10);
            if (result >= 10)
            {
                result %= 10;
            }

            return crnNumber[9] == result;
        }
    }
}