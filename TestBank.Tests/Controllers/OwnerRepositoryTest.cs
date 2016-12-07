using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestBank.Models;
using TestBank.Repositories;

namespace TestBank.Tests.Repositories
{
    [TestClass]
    public class OwnerRepositoryTest
    {
        [TestMethod]
        public void AddOwnerCreatesOwner()
        {
            OwnerRepository testcontext = new OwnerRepository();
            Owner testobject = testcontext.AddOwner();
            Assert.IsNotNull(testobject);
        }

        [TestMethod]
        public void FindOwnerReturnsOwner()
        {
            OwnerRepository testcontext = new OwnerRepository();
            Owner testobject = testcontext.FindOwner(1);
            Assert.IsNotNull(testobject);
        }
    }
}
