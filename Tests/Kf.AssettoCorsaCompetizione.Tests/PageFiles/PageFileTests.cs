using FluentAssertions;
using Kf.AssettoCorsaCompetizione.PageFiles;
using System.IO;
using Xunit;

namespace Kf.AssettoCorsaCompetizione.Tests.PageFiles
{
    public sealed class PageFileTests
    {
        [Fact]
        public void Returns_false_and_PageFileConnectionError_when_file_does_not_exist()
        {
            var sut = new TestPageFile("this\\location\\doesntexist");
            var result = sut.Connect();

            result.Should().NotBeNull();
            result.Success.Should().BeFalse();
            result.ErrorInfo.InnerException.Should().BeOfType<DirectoryNotFoundException>();
        }

        private class TestPageFile : PageFile<object>
        {
            public TestPageFile(string location) 
                : base(location)
            {
            }
        }
    }
}
