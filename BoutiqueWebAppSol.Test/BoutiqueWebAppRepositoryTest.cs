using Xunit;
using BoutiqueWebAppSol.Repository;

namespace BoutiqueWebAppSol.Test
{
    public class WebRepositoryUnitTests
    {
        [Fact]
        public void Should_Display_MainElements_On_PageLoad()
        {
            // Arrange
            var page = new WebRepository.HomePage();

            // Act & Assert
            Assert.False(page.Header.IsVisible, "Header shouldn't be visible on page load.");
            Assert.False(page.Footer.IsVisible, "Footer shouldn't be visible on page load.");
            Assert.False(page.NavigationBar.IsVisible, "Navigation bar shouldn't be visible on page load.");
        }

        [Fact]
        public void Should_Navigate_To_ProductsPage_OnClick()
        {
            // Arrange
            var page = new WebRepository.HomePage();

            // Act
            page.NavigateTo("Products");

            // Assert
            Assert.Equal("Products", page.CurrentPageName);
        }

        [Fact]
        public void Should_Render_Carousel_WithImages()
        {
            // Arrange
            var page = new WebRepository.HomePage();

            // Act
            var images = page.Carousel.GetImages();

            // Assert
            Assert.NotEmpty(images);
            Assert.True(images.Count > 0, "Carousel should contain images.");
        }

        [Fact]
        public void Should_Display_Product_Details_OnClick()
        {
            // Arrange
            var page = new WebRepository.ProductsPage();

            // Act
            page.ClickProduct(1); // Simula el clic en un producto con ID 1

            // Assert
            Assert.True(page.ProductDetails.IsVisible, "Product details should be visible after clicking on a product.");
        }

        [Fact]
        public void Should_Adjust_NavigationBar_On_Smaller_Screens()
        {
            // Arrange
            var page = new WebRepository.HomePage();

            // Act
            page.SetScreenResolution(480, 800); // Establece la resolución de pantalla a 480x800 (simulando una pantalla móvil)

            // Assert
            Assert.True(page.NavigationBar.IsCollapsed, "Navigation bar should be collapsed on smaller screens.");
        }
    }
}
