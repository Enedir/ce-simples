

namespace BrConselhosProva.Domain.Exceptions
{
    public class NotFoundException : BusinessException
    {
        public NotFoundException() : base("Registro não encontrado!")
        {
        }
    }
}
