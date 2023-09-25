using FluentAssertions;
using Reserva.Domain.Entidades;

namespace Reserva.Domain.Tests {

    public class UnitTestHotel {

        [Fact]
        public void CriarHotel_ParametrosValidos_ResultadoValido()
        {
            Action action = () => new Hotel(1, "Las Vegas", "Descricao", 100);

            action.Should().NotThrow<Reserva.Domain.Validacao.DomainExceptionValidation>();
        }

        [Fact]
        public void CriarHotel_NomeInvalido_ResultadoInvalido(){
            Action action = () => new Hotel(1, "", "Descricao", 300);

            action.Should().Throw<Reserva.Domain.Validacao.DomainExceptionValidation>().WithMessage("Nome inválido");
        }
    }
}