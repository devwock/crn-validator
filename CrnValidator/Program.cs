using System;

namespace CrnValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CrnValidator crnValidator = new CrnValidator();

            Console.WriteLine("사업자등록번호를 입력하세요");
            string crn = Console.ReadLine();
            bool isCorrect = crnValidator.IsValidCrn(crn);
            string result = isCorrect ? "올바른 사업자등록번호입니다." : "틀린 사업자등록번호입니다.";

            Console.WriteLine(result);
        }
    }
}