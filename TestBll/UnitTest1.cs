using System;
using System.Collections.Generic;
using BLL;
using Kasaki;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace TestBll
{
    [TestFixture]
    public class UnitTest1
    {
        private BasicOperationDepartament _basicOperationDepartament;
        [Test]
        public void TestGetDepartament()
        {
            DbAutoMapper.Initialize();

        }
    }
}
