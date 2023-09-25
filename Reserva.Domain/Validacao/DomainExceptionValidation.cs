namespace Reserva.Domain.Validacao {
    public class DomainExceptionValidation : Exception{

        public DomainExceptionValidation(string error) : base(error)
        { }


        public static void Quando(bool temErro, string mensagem){
            if(temErro) throw new DomainExceptionValidation(mensagem);
        }

    }
}
