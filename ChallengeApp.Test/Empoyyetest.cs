namespace ChallengeApp.Test
{
    public class Tests
    {
   

     
        [Test]
        public void WhenEmpoyeerCollectTwoSetOfPoints_ShouldReturnCorrectSumAsResult()
        {
            var Empoyye = new Empoyye("Adam", "Kamizelich", 30);
            Empoyye.AddScore(5);
            Empoyye.AddScore(6);

            var result = Empoyye.Result;
            Assert.AreEqual(11, result);
        }
        [Test]
        public void WhenEmpoyeerCollectMinusPoints_ShouldReturnCorrectSumAsResult()
        {
            var Empoyye = new Empoyye("Adam", "Kamizelich", 30);
            Empoyye.AddScore(5);
            Empoyye.AddScore(6);
            Empoyye.AddScore(-1);

            var result = Empoyye.Result;
            Assert.AreEqual(10,result);
        }
    }
}