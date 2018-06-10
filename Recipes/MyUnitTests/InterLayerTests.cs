using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunctionsLibrary;

namespace MyUnitTests
{
    [TestClass]
    public class InterLayerTests
    {
        //clear DB before using Unit-tests
        MyInterLayer layer = new MyInterLayer();

        [TestMethod]
        public void AddTestMethod_1()
        {
            Assert.AreEqual(true, layer.Add("Сосиски", "шт.", 5));
        }

        [TestMethod]
        public void MyProductsTestMethod_1()
        {
            layer.Add("Рыба", "шт.", 3);
            Assert.AreEqual(false, layer.MyProducts("Рыба", 5));
        }

        [TestMethod]
        public void MyProductsTestMethod_2()
        {
            Assert.AreEqual(true, layer.MyProducts("Каракатица", 5));
        }

        [TestMethod]
        public void MyProductsTestMethod_3()
        {
            layer.listProduct.Clear();
            layer.MyProducts("Хлеб", 5, true);
            Assert.AreEqual(1, layer.listProduct.Count);
        }

        [TestMethod]
        public void MyProductsTestMethod_4()
        {
            layer.listProduct.Clear();
            layer.MyProducts("Хлеб", 5, false);
            Assert.AreEqual(0, layer.listProduct.Count);
        }
    }
}
