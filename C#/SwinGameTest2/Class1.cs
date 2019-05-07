using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting; 

namespace SwinGameTest2
{   
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void CheckInBox()
        {
            bool DoesUnitTestWork()
            {
                return true;
            }

            Assert.IsTrue(DoesUnitTestWork()); 
        }
        [TestMethod]
        public void CheckShipNameDestroyer()
        {
            Assert.IsNotNull(ShipName.Destroyer);
        }

        [TestMethod]
        public void ChechShipNameTug()
        {
            Assert.IsNotNull(ShipName.Tug); 
        }

        [TestMethod]
        public void CheckShipNameIsNone()
        {
            Assert.IsNotNull(ShipName.None); 
        }
    }
}
