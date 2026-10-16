using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Gestores {
    public class GestorEntrenadores {
        private List<Entrenador> entrenadores;
        public GestorEntrenadores() {
            entrenadores = new List<Entrenador>();
        }

        public void RegistrarEntrenadora(string nombre, string especialidades) {
            entrenadores.Add(new Entrenador(nombre, especialidades));
        }

        public Entrenador BuscarRutina(string nombre) {
            return entrenadores.FirstOrDefault(e => e.Nombre == nombre);
        }
    }
}
