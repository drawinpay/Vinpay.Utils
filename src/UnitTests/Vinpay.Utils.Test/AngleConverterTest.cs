using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinpay.Utils.Test
{
    [TestClass]
    public class AngleConverterTest
    {
        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(1, 0.0174532925)]
        [DataRow(30, Math.PI / 6)]
        [DataRow(45, Math.PI / 4)]
        [DataRow(60, Math.PI / 3)]
        [DataRow(72, 1.2566370617)]
        [DataRow(90, Math.PI / 2)]
        [DataRow(180, Math.PI)]
        [DataRow(360, Math.PI * 2)]
        [DataRow(925, 16.1442955846)]
        public void DegreeToRadianTest(double degree, double result)
        {
            double radian = degree.DegreeToRadian();
            Assert.IsTrue(Math.Abs(radian - result) < 1E-6);
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(Math.PI / 6, 30)]
        [DataRow(Math.PI / 4, 45)]
        [DataRow(Math.PI / 3, 60)]
        [DataRow(Math.PI / 2, 90)]
        [DataRow(Math.PI, 180)]
        [DataRow(Math.PI * 2, 360)]
        [DataRow(1, 57.2957795)]
        [DataRow(3, 171.8873385)]
        [DataRow(12.35, 707.602876825)]
        public void RadianToDegreeTest(double radian, double result)
        {
            double degreen = radian.RadianToDegree();
            Assert.IsTrue(Math.Abs(degreen - result) < 1E-6);
        }
    }
}
