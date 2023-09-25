using System.ComponentModel.DataAnnotations;

namespace Reserva.Application.DTOs;

public class HotelDTO {

        public int Id { get; private set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        public string? Descricao { get; set; }

}