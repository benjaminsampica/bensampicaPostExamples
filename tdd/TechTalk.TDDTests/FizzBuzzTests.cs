using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechTalk.TDDTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void FizzBuzzer_When1_Returns1() => Assert.AreEqual("1", FizzBuzzer.GetValue(1));

        [TestMethod]
        public void FizzBuzzer_When2_Returns2() => Assert.AreEqual("2", FizzBuzzer.GetValue(2));

        [TestMethod]
        public void FizzBuzzer_When3_ReturnsFizz() => Assert.AreEqual("Fizz", FizzBuzzer.GetValue(3));

        [TestMethod]
        public void FizzBuzzer_When6_ReturnsFizz() => Assert.AreEqual("Fizz", FizzBuzzer.GetValue(6));

        [TestMethod]
        public void FizzBuzzer_When5_ReturnsBuzz() => Assert.AreEqual("Buzz", FizzBuzzer.GetValue(5));

        [TestMethod]
        public void FizzBuzzer_When10_ReturnsBuzz() => Assert.AreEqual("Buzz", FizzBuzzer.GetValue(10));

        [TestMethod]
        public void FizzBuzzer_When15_ReturnsFizzBuzz() => Assert.AreEqual("FizzBuzz", FizzBuzzer.GetValue(15));

        [TestMethod]
        public void FizzBuzzer_When30_ReturnsFizzBuzz() => Assert.AreEqual("FizzBuzz", FizzBuzzer.GetValue(30));
    }
}
