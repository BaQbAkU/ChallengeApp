namespace ChallengeApp.Test
{
    public class Tests
    {
   

     
        [Test]
        public void WhenEmpoyeerCollectTwoSetOfPoints_ShouldReturnCorrectSumAsResult()
        {
            var Employee = new employee("Adam", "Kamizelich", 30);
            Employee.AddScore(5);
            Employee.AddScore(6);

            var result = Employee.Result;
            Assert.AreEqual(11, result);
        }
        [Test]
        public void WhenEmpoyeerCollectMinusPoints_ShouldReturnCorrectSumAsResult()
        {
            var Employee = new employee("Adam", "Kamizelich", 30);
            Employee.AddScore(5);
            Employee.AddScore(6);
            Employee.AddScore(-1);

            var result = Employee.Result;
            Assert.AreEqual(10,result);
        }
    }
}