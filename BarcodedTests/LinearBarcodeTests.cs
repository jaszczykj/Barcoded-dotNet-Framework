using Microsoft.VisualStudio.TestTools.UnitTesting;
using Barcoded;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Barcoded.Tests
{
    [TestClass()]
    public class LinearBarcodeTests
    {
        [TestMethod()]
        public void LinearBarcodeTest()
        {
            LinearBarcode newBarcode = new LinearBarcode("SomeValue", Symbology.GS1128)
            {
                Encoder =
                {
                    Dpi = 300,
                    BarcodeHeight = 200
                }
            };
            string zplString = newBarcode.ZplEncode;
            Assert.IsFalse(string.IsNullOrEmpty(zplString));

            var fileName = Path.GetTempFileName().Replace(".tmp", ".png");
            Console.WriteLine(fileName);
            var b = newBarcode.SaveImage("PNG");
            File.WriteAllBytes(fileName, b);
            Assert.IsTrue(new FileInfo(fileName).Length > 0);

        }
    }
}