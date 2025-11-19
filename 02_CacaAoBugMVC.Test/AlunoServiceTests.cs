using _02_CacaAoBugMVC.Model;

namespace _02_CacaAoBugMVC.Test
{ 
    [TestClass]
    public class AlunoServiceTests
    {
        [TestMethod]
        public void CalcularMedia_DeveRetornarCorreto()
        {
            //Arrange (Preparar)
            var service = new AlunoService();

            //Act (Agir)
            var resultado = service.CalcularMedia(8.0, 7.5, 6.5);

            //Assert (Afirmar) Math.Round arredonda para duas casas decimais
            Assert.AreEqual(7.33,resultado );
        }
        [TestMethod]
        public void CalcularMedia_DeveRetornarErro()
        {
            //Arrange (Preparar)
            var service = new AlunoService();

            //Act (Agir)
            var resultado = service.CalcularMedia(6.0, 5.5, 3.5);

            //Assert (Afirmar) Math.Round arredonda para duas casas decimais
            Assert.AreNotEqual(7.33, resultado);
        }
        [TestMethod]
        public void ObterSituacao_DeveRetornarCorreto()
        {
            var service = new AlunoService();
            var resultadoAprovado = service.ObterSituacao(8.0);
            Assert.AreEqual("Aprovado",resultadoAprovado );

            
            var resultadoEmExame = service.ObterSituacao(6.5);
            Assert.AreEqual("Em Exame Final", resultadoEmExame);

            var resultadoReprovado = service.ObterSituacao(4.9);
            Assert.AreEqual("Reprovado", resultadoReprovado);
        }

    }
}
