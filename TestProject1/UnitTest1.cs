namespace TestProject1
{
    using ClassLibrary1;
    public class Tests
    { 

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void GetNumbers_Throws_ArgumentOutOfRangeException_For_Invalid_Upper_Bound(int upperBound)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Class1.GetNumbers(upperBound, [(3, "Ryan"), (5, "Overton")]));
        }

        [Test]
        public void GetNumbers_Throws_ArgumentOutOfRangeException_For_Upper_Bound_More_Than_ArrayMax()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Class1.GetNumbers(Array.MaxLength + 1, [(3, "Ryan"), (5, "Overton")]));
        }

        [Test]
        public void GetNumbers_Returns_Correct_Number_of_Results()
        {
            var results = Class1.GetNumbers(100, [(3, "Ryan"), (5, "Overton")]);
            Assert.That(100 == results.Count(), ()=> $"Results count ({results.Count()}) should be 100");        
        }

        private static IEnumerable<(int, (int, string)[], string)> SingleModulatorPositiveTestCases()
        {
            yield return (0, [(3, "Ryan")], "1");
            yield return (1, [(3, "Ryan")], "2");
            yield return (2, [(3, "Ryan")], "Ryan");
            yield return (3, [(3, "Ryan")], "4");
            yield return (4, [(3, "Ryan")], "5");
            yield return (5, [(3, "Ryan")], "Ryan");
            yield return (6, [(3, "Ryan")], "7");
            yield return (7, [(3, "Ryan")], "8");
            yield return (8, [(3, "Ryan")], "Ryan");
            yield return (9, [(3, "Ryan")], "10");
            yield return (10, [(3, "Ryan")], "11");
            yield return (11, [(3, "Ryan")], "Ryan");
            yield return (12, [(3, "Ryan")], "13");
            yield return (13, [(3, "Ryan")], "14");
            yield return (14, [(3, "Ryan")], "Ryan");
        }

        [TestCaseSource(nameof(SingleModulatorPositiveTestCases))]
        public void GetNumbers_Returns_Correct_Result_For_Upper_Bound_15_with_Single_Modulator_of_3((int index, (int, string)[] modulators, string expectedValue) gn)
        {
            var results = Class1.GetNumbers(15, gn.modulators);
            Assert.That(results.ElementAt(gn.index) == gn.expectedValue, $"Element at index {gn.index} was expected to be {gn.expectedValue}, but was '{results.ElementAt(gn.index)}'");
        }

        private static IEnumerable<(int, (int, string)[], string)> MultiModulatorPositiveTestCases()
        {
            yield return (0, [(3, "Ryan"), (5, "Overton")], "1");
            yield return (1, [(3, "Ryan"), (5, "Overton")], "2");
            yield return (2, [(3, "Ryan"), (5, "Overton")], "Ryan");
            yield return (3, [(3, "Ryan"), (5, "Overton")], "4");
            yield return (4, [(3, "Ryan"), (5, "Overton")], "Overton");
            yield return (5, [(3, "Ryan"), (5, "Overton")], "Ryan");
            yield return (6, [(3, "Ryan"), (5, "Overton")], "7");
            yield return (7, [(3, "Ryan"), (5, "Overton")], "8");
            yield return (8, [(3, "Ryan"), (5, "Overton")], "Ryan");
            yield return (9, [(3, "Ryan"), (5, "Overton")], "Overton");
            yield return (10, [(3, "Ryan"), (5, "Overton")], "11");
            yield return (11, [(3, "Ryan"), (5, "Overton")], "Ryan");
            yield return (12, [(3, "Ryan"), (5, "Overton")], "13");
            yield return (13, [(3, "Ryan"), (5, "Overton")], "14");
            yield return (14, [(3, "Ryan"), (5, "Overton")], "RyanOverton");
        }

        [TestCaseSource(nameof(MultiModulatorPositiveTestCases))]
        public void GetNumbers_Returns_Correct_Result_For_Upper_Bound_15_with_Modulators_3_and_5((int index, (int, string)[] modulators, string expectedValue) gn)
        {
            var results = Class1.GetNumbers(15, gn.modulators);
            Assert.That(results.ElementAt(gn.index) == gn.expectedValue, $"Element at index {gn.index} was expected to be {gn.expectedValue}, but was '{results.ElementAt(gn.index)}'");
        }

        private static IEnumerable<(int, (int, string)[], string)> EmptyModulatorPositiveTestCases()
        {
            yield return (0, [], "1");
            yield return (1, [], "2");
            yield return (2, [], "3");
            yield return (3, [], "4");
            yield return (4, [], "5");
            yield return (5, [], "6");
            yield return (6, [], "7");
            yield return (7, [], "8");
            yield return (8, [], "9");
            yield return (9, [], "10");
            yield return (10, [], "11");
            yield return (11, [], "12");
            yield return (12, [], "13");
            yield return (13, [], "14");
            yield return (14, [], "15");
        }

        [TestCaseSource(nameof(EmptyModulatorPositiveTestCases))]
        public void Returns_Correct_Result_For_Upper_Bound_15_with_Empty_Modulators((int index, (int, string)[] modulators, string expectedValue) gn)
        {
            var results = Class1.GetNumbers(15, gn.modulators);
            Assert.That(results.ElementAt(gn.index) == gn.expectedValue, $"Element at index {gn.index} was expected to be {gn.expectedValue}, but was '{results.ElementAt(gn.index)}'");
        }
    }
}