using System;


namespace ExercicioTratamentoDeExcecoes.Entities.Exception
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
