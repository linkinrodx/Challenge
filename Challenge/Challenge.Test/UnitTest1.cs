using AutoMapper;
using Challenge.API.Controllers;
using Challenge.API.Models;
using Challenge.Services.Interfaces;
using Moq;
using NUnit.Framework;
using System.Net.Http;

namespace Challenge.Test
{
    public class Tests
    {
        [Test]
        public void GetProductByIdTest()
        {
            //Arrange
            var mockRepo = new Mock<IMapper>();
            var productMock = new Mock<IProductService>();
            var controller = new ProductController(mockRepo.Object, productMock.Object);

            //Act
            var result = controller.GetById(1);

            //Assert
            Assert.AreNotEqual(null, result);
        }

        [Test]
        public void InsertProduct()
        {
            //Arrange
            var mockRepo = new Mock<IMapper>();
            var productMock = new Mock<IProductService>();
            var controller = new ProductController(mockRepo.Object, productMock.Object);

            var obj = new ProductInsertRequest
            {
                Code = "TEST1",
                Description = "Test1",
                ExpirationDate = new System.DateTime(),
                Observations = "Test1",
                ProductTypeId = 1
            };

            //Act
            var result = controller.Insert(obj);

            //Assert
            Assert.AreNotEqual(null, result);
        }

        [Test]
        public void UpdateProduct()
        {
            //Arrange
            var mockRepo = new Mock<IMapper>();
            var productMock = new Mock<IProductService>();
            var controller = new ProductController(mockRepo.Object, productMock.Object);

            var obj = new ProductUpdateRequest
            {
                ProductId = 1,
                State = 1,
                Code = "TEST2",
                Description = "Test2",
                ExpirationDate = new System.DateTime(),
                Observations = "Test2",
                ProductTypeId = 2
            };

            //Act
            var result = controller.Update(obj);

            //Assert
            Assert.AreNotEqual(null, result);
        }
    }
}