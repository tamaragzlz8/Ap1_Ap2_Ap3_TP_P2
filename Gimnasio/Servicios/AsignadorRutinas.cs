using SistemaGimnasio.Modelos;

namespace SistemaGimnasio.Servicios {
    public class AsignadorRutinas {
        public void AsignarRutinaAUsuario(Usuario usuario, Rutina rutina) {
            usuario.AsignarRutina(rutina);
        }

        public void AsignarUsuarioAEntrenador() {
            Entrenador.AsignarUsuario(usuario);
        }
    }
}
