using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestGimnasio
    {
        /// <summary>
        /// Valida que se puedan agregar vinos correctamente
        /// </summary>
        [TestMethod]
        public void AgregarSocios_Ok()
        {
            //Arrange
            Gimnasio<Socio> gimnasio = new Gimnasio<Socio>(3);
            Socio socio1 = new Socio("juan", "perez", 'm', 32122342, Socio.EPase.Musculacion);
            Socio socio2 = new Socio("juan", "gomez", 'm', 32112342, Socio.EPase.Gympass);
            int espacioLibreEsperado = 1;
            int espacioLibre = 0;

            //Act
            gimnasio.Agregar(socio1);
            gimnasio.Agregar(socio2);

            espacioLibre = gimnasio.LugaresLibres;

            //Assert
            Assert.AreEqual(espacioLibre, espacioLibreEsperado);
        }

        /// <summary>
        /// Valida que no se puedan agregar elementos una vez alcancazada la capacidad maxima
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(CapacidadMaximaException))]
        public void AgregarVinos_Exception()
        {
            //Arrange
            Gimnasio<Socio> gimnasio = new Gimnasio<Socio>(1);
            Socio socio1 = new Socio("juan", "perez", 'm', 32122342, Socio.EPase.Musculacion);
            Socio socio2 = new Socio("juan", "gomez", 'm', 32112342, Socio.EPase.Gympass);

            //Act
            gimnasio.Agregar(socio1);
            gimnasio.Agregar(socio2);
        }
    }
}
