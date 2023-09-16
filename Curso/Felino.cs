namespace Curso
{
    public class Felino
    {
        public Felino(string nome, string specie, double peso)
        {
            Nome = nome;
            Specie = specie;
            Peso = peso;
        }

        public string Nome { get; set; }
        public string Specie { get; set; }
        public double Peso { get; set; }
    }
}
