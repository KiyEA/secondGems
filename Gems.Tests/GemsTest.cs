using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.Linq;

namespace Gems.Tests
{
    public class GemsTest
    {
        readonly Gems n = new Gems();

        [Theory]
        [InlineData("GeoMeta")]
        [InlineData("√осударственна€ система обеспечени€ градостроительной де€тельности")]
        [InlineData("√ородска€ аналитика")]
        [InlineData("ƒругие наши проекты")]
        public void Test1(string value)
        {
            var result = n.IsExist(value);
            Assert.True(result);

        }
        [Theory]
        [InlineData("https://xn--c1aaceme9acfqh.xn--p1ai/")]
        public void Test2(string value)
        {
            var result = n.IsSiteExist(value);
            Assert.True(result);
        }
    }

}
