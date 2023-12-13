using Moq;
using NUnit.Framework;
using OnlineShoppingStore.Controllers;
using OnlineShoppingStore.Models.Home;
using System.Web;
using System.Web.Mvc;
namespace OnlineShoppingStore.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {

        [Test]
        public void AddToCart_WithValidProductIdAndUrl_RedirectsToGivenUrl()
        {
            var controller = new HomeController();
            var productId = 1;
            var url = "/somepage"; 
            var httpContextMock = new Mock<HttpContextBase>();
            var sessionMock = new Mock<HttpSessionStateBase>();
            var controllerContextMock = new Mock<ControllerContext>();

            // Set up the HttpContextBase and ControllerContext
            httpContextMock.Setup(c => c.Session).Returns(sessionMock.Object);
            controllerContextMock.Setup(c => c.HttpContext).Returns(httpContextMock.Object);
            controller.ControllerContext = controllerContextMock.Object;
            var result = controller.AddToCart(productId, url) as RedirectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(url, result.Url);
        }

        [Test]
        public void Index_ReturnsViewResultWithModel()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index(null, null) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<HomeIndexViewModel>(result.Model);
        }
        [Test]
        public void Checkout_ReturnsViewResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Checkout() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [Test]
        public void CheckoutDetails_ReturnsViewResult()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.CheckoutDetails() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [Test]
        public void DecreaseQty_WithValidProductId_RedirectsToCheckout()
        {
            // Arrange
            var controller = new HomeController();
            var productId = 1;

            // Set up mock session with a non-null cart
            var sessionMock = new Mock<HttpSessionStateBase>();
            sessionMock.SetupGet(s => s["cart"]).Returns(new List<Item>()); // Assuming 'Item' is your cart item type
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Session).Returns(sessionMock.Object);

            var controllerContextMock = new Mock<ControllerContext>();
            controllerContextMock.Setup(c => c.HttpContext).Returns(httpContextMock.Object);
            controller.ControllerContext = controllerContextMock.Object;

            // Act
            var result = controller.DecreaseQty(productId) as RedirectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Checkout", result.Url);
        }

        [Test]
        public void RemoveFromCart_WithValidProductId_RedirectsToIndex()
        {
            // Arrange
            var controller = new HomeController();
            var productId = 1;

            // Set up mock session with a non-null cart
            var sessionMock = new Mock<HttpSessionStateBase>();
            sessionMock.SetupGet(s => s["cart"]).Returns(new List<Item>()); // Assuming 'Item' is your cart item type
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Session).Returns(sessionMock.Object);

            var controllerContextMock = new Mock<ControllerContext>();
            controllerContextMock.Setup(c => c.HttpContext).Returns(httpContextMock.Object);
            controller.ControllerContext = controllerContextMock.Object;

            // Act
            var result = controller.RemoveFromCart(productId) as RedirectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Index", result.Url);
        }
}
}