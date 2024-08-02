using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{

    [TestClass]
    public class NegocioTest
    {
        [TestMethod]
        public void OrdenarProductosPorPrecio_AscendenteOrdenaCorrectamente()
        {
            // Arrange
            Negocio servicio = Negocio.Instancia;
            var productos = new List<Producto>()
        {
            new Auricular("tune220", "jbl", "lima", 3500F, true, 5, 6, true, true, true),
            new Auricular("tune110", "jbl", "lima", 1320F, true, 5, 6, true, true, true),
            new Entidades.Monitor("Asus", "tuf1", "blanco", 152600F, 22, true, "led", 120, "hdmi", "fullhd")
        };

            // Act
            var resultado = servicio.OrdenarProductosPorPrecio(productos, true);

            // Assert
            Assert.AreEqual(1320F, resultado[0].Precio);
            Assert.AreEqual(3500F, resultado[1].Precio);
            Assert.AreEqual(152600F, resultado[2].Precio);
        }

        [TestMethod]
        public void OrdenarProductosPorPrecio_DescendenteOrdenaCorrectamente()
        {
            // Arrange
            var servicio = Negocio.Instancia;
            var productos = new List<Producto>()
        {
            new Auricular("tune220", "jbl", "lima", 3500F, true, 5, 6, true, true, true),
            new Auricular("tune110", "jbl", "lima", 1320F, true, 5, 6, true, true, true),
            new Entidades.Monitor("Asus", "tuf1", "blanco", 152600F, 22, true, "led", 120, "hdmi", "fullhd")
        };

            // Act
            var resultado = servicio.OrdenarProductosPorPrecio(productos, false);

            // Assert
            Assert.AreEqual(152600F, resultado[0].Precio);
            Assert.AreEqual(3500F, resultado[1].Precio);
            Assert.AreEqual(1320F, resultado[2].Precio);
        }

        [TestMethod]
        public void OrdenarProductosPorPrecio_ListaVaciaDevuelveListaVacia()
        {
            // Arrange
            var servicio = Negocio.Instancia;
            var productos = new List<Producto>();

            // Act
            var resultado = servicio.OrdenarProductosPorPrecio(productos, true);

            // Assert
            Assert.AreEqual(0, resultado.Count);
        }




        
        [TestMethod]
        public void ObtenerCantidadProductoBuscado_NoEncuentraProductoDevuelveCero()
        {
            // Arrange
            var productoBuscado = new Auricular { Modelo = "no-existe", Marca = "JBL", Cantidad = 0 };
            var servicio = Negocio.Instancia;

            // Act
            var resultado = servicio.ObtenerCantidadProductoBuscado(servicio, productoBuscado);

            // Assert
            Assert.AreEqual(0, resultado);
        }

        
    }
}
