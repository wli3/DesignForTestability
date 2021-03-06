using designIssueExample.DataAccess;
using NUnit.Framework;

namespace designIssueExample.Tests
{
    [TestFixture]
    [Category("characterization test")]
    [Category("slow test")]
    public class CharacterizationTests
    {
        [Test]
        public void Yucky_IterateThroughtTheEmployee_outputShouldBeSameAsOriginalOutput()
        {
            var yucky = new EmployeeRepository(new FakeSqlDriver());
            var employees = yucky.GetEmployees(EmployeeFilterType.ByName, "T");
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