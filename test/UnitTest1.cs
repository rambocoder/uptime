using System;
using Xunit;
using uptime.Controllers;

namespace test
{
    public class UnitTest1
    {
        private readonly HomeController _homeController = new HomeController();
        [Fact]
        public void Test1()
        {

            var teams = _homeController.GetAllTeams();

        }
    }
}
