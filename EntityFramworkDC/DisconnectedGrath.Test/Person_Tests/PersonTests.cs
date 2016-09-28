using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DisconnectedGrath.Data.Model.Context;
using DisconnectedGrath.Data.Model;
using System.Linq;

namespace DisconnectedGrath.Test.Person_Tests
{
    [TestClass]
    public class PersonTests
    {
        private MyModel context;
        [TestInitialize]
        public void SetUp()
        {
            context = new MyModel();
        }

        [TestMethod]
        public void TestMethod1()
        {
            var person = new Person();
            var persons = context.Person.ToList();


            Assert.IsNotNull(persons);
        }
    }
}
