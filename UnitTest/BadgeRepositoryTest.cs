using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class BadgeRepositoryTest
    {
        private BadgeRepository _repo;
        private Badge _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new BadgeRepository();
            _content = new Badge();
            _repo.Add(_content);
        }
        //Add Method

        [TestMethod]
        public void CreateAClaim()
        {
            //Arrange---Setting up the playing field
            Badge content = new Badge();
            content.BadgeID = 1;
            BadgeRepository repository = new BadgeRepository();

            //Act---Get/run the code we want to test
            bool addResult = repository.Add(content);

            //Assert--- Use the assert class to verify 
            Assert.IsTrue(addResult);
        }




        [TestMethod]

        public void DeleteClaim_ShouldReturnTrue()
        {
            //Arrange
            _repo = new BadgeRepository();
            _content = new Badge();
            _repo.Add(_content);
            //Act
            bool deleteResult = _repo.Remove(_content);
            //Assert
            Assert.IsTrue(deleteResult);

        }


    }



}


