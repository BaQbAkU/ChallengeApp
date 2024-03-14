

namespace ChallengeApp.Test
{
    public class ChallengeApp
    {
        [Test]
        public void CheckMethodGetStatisticMin()

        {
            var employee = new Employee("Adam", "Kamizelich", 30);
            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(15);
            employee.AddGrade(20);
            employee.AddGrade(25);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(5,statistics.Min);

        }


        [Test]
        public void CheckMethodGetStatisticMax()

        {
            var employee = new Employee("Adam", "Kamizelich", 30);
            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(15);
            employee.AddGrade(20);
            employee.AddGrade(25);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(25, statistics.Max);

        }

        [Test]
        public void CheckMethodGetStatisticAverage()

        {
            var employee = new Employee("Adam", "Kamizelich", 30);
            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(15);
            employee.AddGrade(20);
            employee.AddGrade(25);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(15, statistics.Average);

        }
    }
    

}
