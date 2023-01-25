using homeWork6;

namespace HomeWork.Tests
{
    public class Tests
    {
        [Test]
        public void DoubleSumOfCollectedPoints()
        {
            var user = new Employee("adam", "iuewfhuewh", 8);
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(2);
            user.AddScore(1);
            user.AddScore(3);
            user.AddScore(4);

            var result = user.Result;

            Assert.AreEqual(42, result);
        }
    }
}