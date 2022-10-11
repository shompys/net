using CoreSchool.Entities;

namespace CoreEscuela
{
    public class EscuelaEngine {
        public School? Escuela { get; set; }

        public EscuelaEngine() {}
        public void Inicializar() {
            this.Escuela = new School("university Jonas", "av. siempreviva 123", 1900, "argentina", "Buenos Aires", TypesSchool.primaria);
            this.Escuela.ListCursos= new List<Curso>(){
                new Curso { Name="Sarmiento pirulo", Jornada= TypesJornada.Mañana },
                new Curso { Name="San martin de rucu", Jornada= TypesJornada.Tarde },
                new Curso { Name="Mariquita sanchez de thompson", Jornada= TypesJornada.Noche },
            }; 
        }
    }
}