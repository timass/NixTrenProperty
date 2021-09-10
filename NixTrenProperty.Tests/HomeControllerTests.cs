using Microsoft.AspNetCore.Mvc;
using NixTrenProperty.Controllers;
using OnionApp.Domain.Interfaces;
using OnionApp.Infrastructure.Data;
using System;
using Xunit;
using Moq;
using System.Collections.Generic;
using OnionApp.Domain.Core;

namespace NixTrenProperty.Tests
{
    public class HomeControllerTests
    {        
            [Fact]
            //public void IndexReturnsAViewResultWithAListOfAdverts()
            //{
            //    // Arrange
            //    var mock = new Mock<IRepository<Advert>>();
            //    mock.Setup(repo => repo.GetAll()).Returns(GetAdverts());
            //    var controller = new HomeController(mock.Object);

            //    // Act
            //    var result = controller.Index();

            //    // Assert
            //    var viewResult = Assert.IsType<ViewResult>(result);
            //    var model = Assert.IsAssignableFrom<IEnumerable<Advert>>(viewResult.Model);
            //    Assert.Equal(GetAdverts().Count, model.Count());
            //}
            private List<Advert> GetAdverts()
            {
            var users = new List<Advert>
            {
                new Advert {Id=new Guid(), DateOfAdd=DateTime.Today, DateConfirm=DateTime.Today, typeObj="Plot", ObjectSId= new Guid(),
                    UserName= "Vania", RentOrSeal=true, PaimentConditions= "dldldl", FirstPrice = 100, LastPrice=90, City = "FGF"},

                new Advert { Id = new Guid(), DateOfAdd = DateTime.Today, DateConfirm = DateTime.Today, typeObj = "Plot", ObjectSId = new Guid(),
                UserName = "Vitia", RentOrSeal = true, PaimentConditions = "dldldl", FirstPrice = 100, LastPrice = 90, City = "fgdgdf" },

                new Advert { Id = new Guid(), DateOfAdd = DateTime.Today, DateConfirm = DateTime.Today, typeObj = "Plot", ObjectSId = new Guid(),
                    UserName = "Tima", RentOrSeal = true, PaimentConditions = "dldldl", FirstPrice = 100, LastPrice = 90, City = "ghjgjgjjgj" },

                new Advert { Id = new Guid(), DateOfAdd = DateTime.Today, DateConfirm = DateTime.Today, typeObj = "Plot", ObjectSId = new Guid(),
                    UserName = "Vania", RentOrSeal = true, PaimentConditions = "dldldl", FirstPrice = 100, LastPrice = 90, City = "tyyytyuuuu" },
            };
               return users;            
        }
    }
}
