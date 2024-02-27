using ChallengeApp;

namespace ChallengeApp.Test
{
    public class Tests
    {
   

     
        [Test]
        public void WhenEmpoyeerCollectTwoSetOfPoints_ShouldReturnCorrectSumAsResult()
        {
            var employee1 = new Employee("Adam", "Kamizelich", 30);
            employee1.AddScore(5);
            employee1.AddScore(6);

            var result = employee1.Result;
            Assert.AreEqual(11, result);
        }
        [Test]
        public void WhenEmpoyeerCollectMinusPoints_ShouldReturnCorrectSumAsResult()
        {
            var employee1 = new Employee("Adam", "Kamizelich", 30);
            employee1.AddScore(5);
            employee1.AddScore(6);
            employee1.AddScore(-1);

            var result = employee1.Result;
            Assert.AreEqual(10,result);
        }
    }
}
