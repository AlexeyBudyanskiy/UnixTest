using Xunit;

namespace UnixTestApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_App()
        {
            var result = Program.GenerateText();

            Assert.True(result.Equals("Application works!"));
        }
    }
}
