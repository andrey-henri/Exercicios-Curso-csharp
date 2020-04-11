using System;

namespace ExercicioVetor
{
    class Quarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Quarto (string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        public override string ToString()
        {
            return ": " + Nome + ", " + Email;
        }
    }
}