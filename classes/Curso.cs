namespace CoreSchool.Entities {
    public class Curso {
        public string UniqueId { get; private set; }
        public string? Name { get; set; }
        public TypesJornada? Jornada { get; set; }

        public Curso() => UniqueId = Guid.NewGuid().ToString();

        public static void ImprimirCursoWhile(Curso[] cursos) {
            int count = 0;
            while(count < cursos.Length) {
                Console.WriteLine(cursos[count].Name);
                count++;
            }
        }
        public static void ImprimirCursoDoWhile(Curso[] cursos) {
            int count = 0;
            do {
                Console.WriteLine(count);
                Console.WriteLine(cursos[count].Name);
            } while(++count < cursos.Length);
            //asigna el valor antes de evaluar la expresion entonces:
            //pregunta 1 < 3, 2 < 3, 3 < 3
        }
        public static void ImprimirCursoFor(Curso[] cursos) {
            int max = cursos.Length;
            for(int i = 0; i < max; i++) {
                Console.WriteLine(cursos[i].Name);
            }
        }
        public static void ImprimirCursoForEach(Curso[] cursos) {
            foreach(var curso in cursos){
                Console.WriteLine(curso.Name);
            }
        }
        public override string ToString() {
            return "Curso { " + $"ID: {this.UniqueId}, Name: {this.Name}, Jornada: {this.Jornada}" + " }";
        }
    }
}