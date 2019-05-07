﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Recognizers.Text.DataDrivenTests.Choice
{
    [TestClass]
    public class TestChoice_Portuguese : TestBase
    {
        public static TestResources TestResources { get; protected set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            TestResources = new TestResources();
            TestResources.InitFromTestContext(context);
        }

        [TestInitialize]
        public void TestInitialize()
        {
            TestSpecInitialize(TestResources);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "BooleanModel-Portuguese.csv", "BooleanModel-Portuguese#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void BooleanModel()
        {
            TestChoice();
        }
    }
}
