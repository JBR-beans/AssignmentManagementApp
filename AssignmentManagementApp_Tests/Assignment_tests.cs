using AssignmentManagementApp;
using Xunit.Sdk;

namespace AssignmentManagementApp_Tests
{
	public class Assignment_tests
	{
		[Fact]
		public void IsAssignmentValid()
		{
			Assignment tsl = new Assignment();
			Assert.IsType<Assignment>(tsl);
			// would need to be of type Assignment to pass, but instead is passed type object
		}
	}
}
