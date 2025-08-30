
namespace Aluno.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }


        public bool ehmaiordeidade()
        {
            return Idade >= 18;
        }
    }
}