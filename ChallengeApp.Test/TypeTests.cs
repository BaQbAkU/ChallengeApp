namespace ChallengeApp.Test
{
    public class TypeTests
    {
        [Test]
        public void TestTypuWartościowegoStringName()
        {
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Adam");
            Assert.AreEqual(employee1.Name, employee2.Name);

        }
        [Test]
        public void TestTypuReferencyjnegoStringName()
        {
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Adam");
            Assert.AreNotEqual(employee1, employee2);

        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
        [Test]
        public void TestTypuWartościowegoInt()
        {
            int number1 = 1;
            int number2 = 1;
            Assert.AreEqual(number1, number2);

        }

    }
}
