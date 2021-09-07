namespace DrCash.Domain.Entities.ValueObjects
{
    public class Nome : DrCash.CrossCutting.ValueObjects.ValueObjects
    {
        public Nome() { }

        public string PrimeiroNome { get; set; }
        public string Sobrenome { get; set; }
    }
}
