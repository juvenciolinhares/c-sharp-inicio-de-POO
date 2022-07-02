using System;


namespace ExercicioDeFixacao_Vetores_
{
    internal class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Estudante()
        {

        }
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
            
        }

        public override string ToString()
        {
            return
                 Nome
                + ", "
                + Email;
        }
    }
}
