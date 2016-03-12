using NUnit.Framework;

namespace designIssueExample.Tests
{
    [TestFixture]
    [Category("characterization test")]
    public class ProgramTest
    {
        [Test]
        public void Yucky_IterateThroughtTheEmployee_outputShouldBeSameAsOriginalOutput()
        {
            var yucky = new Yucky();
            var employees = yucky.GetEmployees(EmployeeFilterType.ByName, "T", new FakeSqlConnection());
            var allOutput = "";
            const string expectedOutput = "35323 Ted theRed 16 False\n35323 Tina Turnbull 18 False\n";
            foreach (var employee in employees)
            {
                allOutput += (employee + "\n");
            }
            Assert.AreEqual(expectedOutput, allOutput);
        }
    }
}