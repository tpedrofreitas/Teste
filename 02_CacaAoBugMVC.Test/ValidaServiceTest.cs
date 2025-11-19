using _02_CacaAoBugMVC.Model;

namespace _02_CacaAoBugMVC.Test
{
    [TestClass]
    public class ValidaServiceTest
    {
        [TestMethod]

        public void ValidaNome_NomeValido_DeveRetornarTrue()
        {
            var service = new ValidaService();
            string mensagemErro;

            bool resultado = service.ValidaNome("Carlos Silva", out mensagemErro);

            Assert.IsTrue(resultado);
            Assert.AreEqual(mensagemErro, "");

        }

        [TestMethod]
        public void ValidaNome_NomeVazio_DeveRetornarFalse()
        {
            var service = new ValidaService();
            string mensagemErro;

            bool resultado = service.ValidaNome("", out mensagemErro);
            Assert.IsFalse(resultado);
            Assert.AreNotEqual(mensagemErro, "");


        }
        [TestMethod]
        public void ValidaNome_NomeComMenosDeTresCaracteres_DeveRetornarFalse()
        {
            var service = new ValidaService();
            string mensagemErro;

            bool resultado = service.ValidaNome("Th",out  mensagemErro);
            Assert.IsFalse(resultado);
            Assert.AreNotEqual(mensagemErro, "");
        }
        [TestMethod]
        public void ValidaNome_EspacoDuplo_DeveRetornarFalse()
        {
            var service = new ValidaService();
            string mensagemErro;

            bool resultado = service.ValidaNome("ThIago  Freitas", out mensagemErro);
            Assert.IsFalse(resultado);
            Assert.AreNotEqual(mensagemErro, "");
        }
        [TestMethod]
        public void ValidaNome_CaracteresInvalidos_DeveRetornarFalse()
        {
            var service = new ValidaService();
            string mensagemErro;

            bool resultado = service.ValidaNome(" Thiago123@", out mensagemErro);
            Assert.IsTrue(resultado);
            Assert.AreEqual(mensagemErro, "");

        }
        [TestMethod]
        public void ValidaNota_ValorComVirgula_DeveRetornarTrue()
        {
            var service = new ValidaService();
           

            bool resultado = service.ConverteNota("7,5", out double nota);
            Assert.IsTrue(resultado);    
           
        }
        [TestMethod]
        public void ValidaNota_ValorComPonto_DeveRetornarTrue()
        {
            var service = new ValidaService();

            bool resultado = service.ConverteNota("7.5", out double nota);
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void ValidaNota_NotaMenorQueZero_DeveRetornarFalse()
        {
            var service = new ValidaService();
            bool resultado = service.ConverteNota("-1", out double nota);
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void ValidNota_TextoInvalido_DeveRetornarFalse()
        {
            var service = new ValidaService();

            bool resultado = service.ConverteNota("abc", out double nota);
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void ValidaNota_CampoVazio_DeveRetornarFalse()
        {
            var service = new ValidaService();
            bool resultado = service.ConverteNota("", out double nota);
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void ValidaNota_FormatoNumericoIncorreto_DeveRetornarFalse()
        {
            var service = new ValidaService();
            bool resultado = service.ConverteNota("10.,0", out double nota);
            Assert.IsFalse(resultado);

        }






    }
}
