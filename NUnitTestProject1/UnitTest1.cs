using ConsoleApp1;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            NationalNumberToWords nationalNumberToWords = new NationalNumberToWords();
            bool Result = false;
            string ExResult = "TEN CRORE ";
            string AcResult = nationalNumberToWords.ConvertNumbertoWords(100000000);
            if (ExResult == AcResult)
                Result = true;
            else
                Result= false;
            Assert.That(Result);
        }

        [Test]
        public void Test2()
        {
            InternationalNumberToWords internationalNumberToWords = new InternationalNumberToWords();
            bool Result = false;
            string ExResult = "ONE HUNDRED  Million ";
            string AcResult = internationalNumberToWords.ConvertNumbertoWords(100000000);
            if (ExResult == AcResult)
                Result = true;
            else
                Result = false;
            Assert.That(Result);
        }

    }
}