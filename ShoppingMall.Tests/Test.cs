using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingMall.Domain.Entities;
using ShoppingMall.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ShoppingMall.Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestDB()
        {
            using (UnitOfWork work = new UnitOfWork())
            {
               
            }


        }
    }
}
