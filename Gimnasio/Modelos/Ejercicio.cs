
namespace SistemaGimnasio.Modelos {
    public class Ejercicio {
        public string Nombre {  get; set; }
        public int Repeticiones { get; set; }
        public int Series {  get; set; }
        public int Descansos { get; set; }

        public Ejercicio(string nombre, int repeticiones, int series, int descansos) {
            Nombre = nombre;
            Repeticiones = repeticiones;
            Series = series;
            Descansos = descansos;
        }
    }
}
