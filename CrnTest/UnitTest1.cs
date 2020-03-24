using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrnTest
{
    [TestClass]
    public class UnitTest1
    {
        private CrnValidator.CrnValidator crnValidator { get; set; } = new CrnValidator.CrnValidator();

        [TestMethod]
        public void TestValid()
        {
            string kakaoCrn = "120-81-47521"; // 카카오 사업자등록번호
            string googleCrn = "120-86-65164"; // 구글코리아 사업자등록번호
            string naverCrn = "220-81-62517"; // 네이버 사업자등록번호
            Assert.IsTrue(crnValidator.IsValidCrn(kakaoCrn));
            Assert.IsTrue(crnValidator.IsValidCrn(googleCrn));
            Assert.IsTrue(crnValidator.IsValidCrn(naverCrn));
        }

        [TestMethod]
        public void TestInvalid()
        {
            string crn1 = "";
            string crn2 = " ";
            string crn3 = "abcdefghij";
            string crn4 = "1234567890";
            string crn5 = "123-45-67890";
            Assert.IsFalse(crnValidator.IsValidCrn(crn1));
            Assert.IsFalse(crnValidator.IsValidCrn(crn2));
            Assert.IsFalse(crnValidator.IsValidCrn(crn3));
            Assert.IsFalse(crnValidator.IsValidCrn(crn4));
            Assert.IsFalse(crnValidator.IsValidCrn(crn5));
        }
    }
}