﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting; 

namespace SwinGameTest2
{   
    [TestClass]
    public class Class1
    {   //Chris
        [TestMethod]
        public void TestUnitTest()
        {
            bool DoesUnitTestWork()
            {
                return true;
            }

            Assert.IsTrue(DoesUnitTestWork()); 
        }
        //Chris
        [TestMethod]
        public void CheckShipNameDestroyer()
        {
            Assert.IsNotNull(ShipName.Destroyer);
        }
        //Chris
        [TestMethod]
        public void ChechShipNameTug()
        {
            Assert.IsNotNull(ShipName.Tug); 
        }
        //Chris 
        [TestMethod]
        public void CheckShipNameIsNone()
        {
            Assert.IsNotNull(ShipName.None); 
        }
        //Chris
        [TestMethod]
        public void TestResultofAttackEnumMiss()
        {
            Assert.AreEqual(1, (int)ResultOfAttack.Miss); 
        }
        //Mitch
        [TestMethod]
        public void TestResuloffAttackEnumDestroyed()
        {
            Assert.AreEqual(2  ,(int)ResultOfAttack.Destroyed);
        }
    }
}
