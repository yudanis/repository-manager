using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryManager;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        RepositoryManager.RepositoryManager repomanager = RepositoryManager.RepositoryManager.GetInstance();

        [TestMethod]
        public void EnsureItCanRegisterItemWithCorrectType()
        {
            repomanager.Register("jsonItem", "{\"name\":\"John\", \"age\":30, \"car\":null}", 0);

            string item = repomanager.Retrieve("jsonItem");
            Assert.IsTrue(repomanager.Retrieve("jsonItem") != null);
            Assert.IsTrue(repomanager.GetType("jsonItem") == 0);

            repomanager.Register("xmlItem", "<customer>John Smith</customer>", 1);

            string itemxml = repomanager.Retrieve("xmlItem");
            Assert.IsTrue(repomanager.Retrieve("xmlItem") != null);
            Assert.IsTrue(repomanager.GetType("xmlItem") == 1);

            try
            {
                repomanager.Register("jsonItem", "{\"name\":\"John\", \"age\":30, \"car\":null}", 0);
                Assert.Fail("No exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(ArgumentException));
                Assert.IsTrue(ex.Message == "Item is already exist and can not be override");
            }
            
        }

      
    }
}
