using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharprWowApi.Test
{
    [TestClass]
    public class UnitTestProfile
    {
        [TestMethod]
        public void Test_US_Profile_Using_Access_Token()
        {
            var client = new ApiClient(Region.US, Locale.en_US, "tpnk4hp48aekhq7qczajh2edup6c6g2z");

            var profile = client.GetProfile("gfgbgxwxgbmhqh3q5jr2gku3");

            Assert.IsNotNull(profile);
            Assert.IsNotNull(profile.Characters);

        }
    }
}
