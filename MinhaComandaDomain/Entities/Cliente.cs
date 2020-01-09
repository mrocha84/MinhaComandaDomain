namespace MinhaComandaDomain.Entities
{
    public class Cliente : Entidade
    {
        public string Nome { get; set; }
        public int? Telefone { get; set; }
        public string Email { get; set; }
    }
}