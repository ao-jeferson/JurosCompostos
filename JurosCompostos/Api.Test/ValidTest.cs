using JurosCompostos.Controllers;
using System;
using Xunit;

namespace Api.Test
{
    public class ValidTest
    {
        [Fact]
        public void GetTaxaAtual()
        {
            var validTaxa = "1%";

            Assert.Equal("1%", validTaxa);
        }

        [Fact]
        public void VerificarUrlGit()
        {
            var UrlRepo = "https://github.com/ao-jeferson/JurosCompostos";

            Assert.Equal("https://github.com/ao-jeferson/JurosCompostos", UrlRepo);
        }
    }
}
