using System.Collections.Generic;

namespace BoutiqueWebAppSol.Repository
{
    public class WebRepository
    {
        // Simulación de la clase para elementos como encabezado, pie de página y barra de navegación
        public class PageElement
        {
            public bool IsVisible { get; set; }
        }

        public class HomePage
        {
            public PageElement Header { get; set; } = new PageElement { IsVisible = false };
            public PageElement Footer { get; set; } = new PageElement { IsVisible = false };

            // Barra de navegación con propiedad IsCollapsed específica
            public NavigationBar NavigationBar { get; set; } = new NavigationBar();
            public Carousel Carousel { get; set; } = new Carousel();
            public string CurrentPageName { get; set; }

            // Método de navegación para simular el clic en un enlace
            public void NavigateTo(string pageName)
            {
                CurrentPageName = pageName;
            }

            // Cambiar la resolución de pantalla para la prueba de diseño responsivo
            public void SetScreenResolution(int width, int height)
            {
                NavigationBar.IsCollapsed = (width < 768); // Ejemplo: NavBar se colapsa en pantallas < 768px
            }
        }

        public class ProductsPage : HomePage
        {
            public PageElement ProductDetails { get; set; } = new PageElement();

            // Clic en un producto que muestra detalles
            public void ClickProduct(int productId)
            {
                // Simula mostrar los detalles del producto al hacer clic
                ProductDetails.IsVisible = true;
            }
        }

        public class Carousel
        {
            private List<string> images = new List<string> { "image1.jpg", "image2.jpg", "image3.jpg" };

            // Método para obtener imágenes del carrusel
            public List<string> GetImages()
            {
                return images;
            }
        }

        // Nueva clase para la barra de navegación con la propiedad IsCollapsed
        public class NavigationBar : PageElement
        {
            public bool IsCollapsed { get; set; }
        }
    }
}
