using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConfigEditorApi.src;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConfigEditorApi.src.Tests
{
    [TestClass()]
    public class FunctionsTests
    {
        [TestMethod()]
        public void GetAllFileNameTest()
        {
            Functions functions = new Functions();
            Assert.IsNotNull(functions.GetAllFileName());
        }

        [TestMethod()]
        public void GetConfigTextTest()
        {
            Functions functions = new Functions();
            string FileName = functions.GetAllFileName()[0];
            Assert.AreEqual(functions.GetConfigText("dsad.txt"), "File not found.");
            Assert.IsNotNull(functions.GetConfigText(FileName), "File found");
        }
    }
}