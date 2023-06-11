

namespace CORE.PELUQUERIA.Entities
{
    public partial class Persona
    {
        public decimal IdPersona { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string? ApellidoDos { get; set; }
        public bool? Estado { get; set; }
        public byte[]? Foto { get; set; }
    }
}
