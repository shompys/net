using static System.Console; // evito repetir Console.WriteLine

namespace CoreSchool.Entities {

    public class School {
        // string name;
        
        // public string Name {
        //     get { return name; }
        //     set { name = value.ToUpper(); }
        // }
        public string Name { get; set; }
        public string Address { get; set; }
        public int YearCreated { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public TypesSchool Type { get; set; }

        public Curso[]? Cursos { get; set; }
        public List<Curso>? ListCursos { get; set; }

        public School(string name, string address, int yearCreated, TypesSchool type, string country="", string city="") {
            this.Name = name;
            this.Address = address;
            this.YearCreated = yearCreated;
            this.Type = type;
            this.Country = country;
            this.City = city;
        }
        public School(
            string name, 
            string address, 
            int yearCreated, 
            string country, 
            string city,
            TypesSchool type
        ) => (Name, Address, YearCreated, Country, City, Type) = (name, address, yearCreated, country, city, type);

        public void Timbrar() {
            Console.WriteLine($"Riiing");
        }

        public override string ToString()
        {
            return "School: { " + $"Name: {this.Name}, Address: {this.Address}, YearCreated: {this.YearCreated}, Country: {this.Country}, City: {this.City}, Type: {this.Type}, Cursos: {this.Cursos}" + " }";
        }
        public void imprimirCursos(){
            if(this.Cursos == null) return;
            foreach(Curso curso in this.Cursos){
                WriteLine(curso.Name);
            }
        }
        public void printListCursos(){
            if(this.ListCursos == null) return;
            foreach(Curso listCurso in this.ListCursos){
                WriteLine(listCurso);
            }
            CoreEscuela.Util.Printer.DibujarLinea(3000);
        }

    }
}
