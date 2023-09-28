using Reserva.Domain.Validacao;

namespace Reserva.Domain.Entidades{

    public sealed class Hotel {

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public int QntQuartos { get; private set; }

        public Hotel(string nome, string descricao ){

            DomainExceptionValidation.Quando(string.IsNullOrEmpty(nome), "Nome inválido");

            DomainExceptionValidation.Quando(string.IsNullOrEmpty(descricao), "Descrição inválido");

            Nome = nome;
            Descricao = descricao;
        }

        public Hotel(int id, string nome, string descricao, int qntQuartos)
        {
            DomainExceptionValidation.Quando(id < 0, "Id negativo inválido");

            DomainExceptionValidation.Quando(string.IsNullOrEmpty(nome), "Nome inválido");

            DomainExceptionValidation.Quando(string.IsNullOrEmpty(descricao), "Descrição inválido");

            DomainExceptionValidation.Quando(qntQuartos < 0, "Quantidade de Quartos inválido");

            Id = id;
            Nome = nome;
            Descricao = descricao;
            QntQuartos = qntQuartos;
        }
    }
}
