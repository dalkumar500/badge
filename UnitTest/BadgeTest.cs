using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class BadgeTest
    {
        [TestMethod]
          public void SetTitle_ShouldSetCorrectString()
            {
                //Arrange
                Badge idnumber = new Badge();

                idnumber.BadgeID = 1234;

                //Act

                int expected = 1234;
                int actual = idnumber.BadgeID;

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }

    