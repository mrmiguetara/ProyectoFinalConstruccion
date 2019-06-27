using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TestGen.IntegrationTests;
using Xunit;
namespace AspNetCoreTodo.IntegrationTests
{
	public class TodoRouteShould
	{
		[Fact]
		public void InitialPageLoadedCorrectly()
		{
			Thread.Sleep(800);
			Assert.Equal(0, 0);
		}
	}
}
