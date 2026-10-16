
namespace SistemaGimnasio.Modelos {
    public class Entrenador 
    {
        public string Nombre {  get; set; }
        public string Especialidad { get; set; }
        private List<Usuario> usuariosAsignados;

        public Entrenador(string nombre, string especialidad) {
            Nombre = nombre;
            Especialidad = especialidad;
            
        }

        public AsignarUsuario() {

        }

    }
}
