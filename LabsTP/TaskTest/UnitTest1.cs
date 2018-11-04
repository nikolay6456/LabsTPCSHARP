using LabTPFirst;
using NUnit.Framework;

namespace TaskTest
{
    public class Tests
    {
        private Task _task;

        [SetUp]
        public void Setup()
        {
            _task = new Task();
        }

        [Test]
        public void GetMatchesWordTest1()
        {
            string[] expected = {"Tea", "teA", "tEa"};
            var matchCollection = _task.GetMatchesWord("Tea like teA tasty tEa", "tea");
            var act = new string[matchCollection.Count];
            var enumerator = matchCollection.GetEnumerator();
            for (var i = 0; i < matchCollection.Count; i++)
                if (enumerator.MoveNext())
                    act[i] = enumerator.Current.ToString();
            Assert.AreEqual(act, expected);
        }

        [Test]
        public void GetMatchesWordTest2()
        {
            var expected = new string[0];
            var matchCollection = _task.GetMatchesWord("data value", "tea");
            var act = new string[matchCollection.Count];
            var enumerator = matchCollection.GetEnumerator();
            for (var i = 0; i < matchCollection.Count; i++)
                if (enumerator.MoveNext())
                    act[i] = enumerator.Current.ToString();
            Assert.AreEqual(act, expected);
        }

        [Test]
        public void GetMatchesWordTest3()
        {
            var matchCollection = _task.GetMatchesWord("data value", string.Empty);
            Assert.IsNull(matchCollection);
        }

        [Test]
        public void GetMatchesWordTest4()
        {
            var matchCollection = _task.GetMatchesWord("data value", string.Empty);
            Assert.IsNull(matchCollection);
        }

        [Test]
        public void GetMatchesWordTest5()
        {
            var matchCollection = _task.GetMatchesWord(string.Empty, string.Empty);
            Assert.IsNull(matchCollection);
        }

        [Test]
        public void MathSys1()
        {
            var result = _task.MathSys(-2);
            Assert.AreEqual(result, double.NaN);
        }

        [Test]
        public void MathSys2()
        {
            var result = _task.MathSys(-0.25);
            Assert.AreEqual(result, 0.00390625d);
        }

        [Test]
        public void MathSys3()
        {
            var result = _task.MathSys(2);
            Assert.AreEqual(result, 1.1578212823495775d);
        }
    }
}