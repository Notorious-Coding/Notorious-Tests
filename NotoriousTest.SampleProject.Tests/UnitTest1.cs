using NotoriousTest.Common;
using NotoriousTest.SampleProject.Tests.SUT;
using NotoriousTest.SampleProject.Tests.SUT.Infrastructures;

namespace NotoriousTest.SampleProject.Tests
{

    public class UnitTest1 : AsyncIntegrationTest<SampleEnvironment>
    {
        public UnitTest1(SampleEnvironment environment) : base(environment)
        {
        }

        [Fact]
        public async Task Test2()
        {
            HttpClient? client = (await CurrentEnvironment.GetWebApplication()).HttpClient;

            HttpResponseMessage response = await client!.GetAsync("api/weather");
            Assert.True(response.IsSuccessStatusCode);

            string content = await response.Content.ReadAsStringAsync();
        }
    }
}