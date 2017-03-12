using System;
using NUnit.Framework;
using AuthServer;
using System.IO;
using Core;
using System.Collections.Generic;
using System.Linq;

namespace NunitTest
{
    [TestFixture(typeof(Destop))]
    public class TestAuthentication<T> where T: ApiAuth, new()
    {
        ApiAuth dp = new T();
        [TestCase( TestName ="LogIn")]
        public void TestLogIn()
        {
            string tmp =  dp.api.LogIn(new Person("1", "1", "null"));
            StringAssert.Contains(tmp, "User exists");
        }
        [TestCase(TestName = "LogInError")]
        public void TestLogError()
        {
            string tmp = dp.api.LogIn(new Person("0", "0", "null"));
            StringAssert.Contains(tmp, "You have registered");
        }
    }
}
