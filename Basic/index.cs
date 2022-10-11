using CoreSchool.Entities;

namespace Basic {
    
    class Tanteador {
        public static void jugandoArray(School school) {
            // var cursos = new Curso[] {
            //     new Curso() {
            //         Name="101",
            //     },
            //     new Curso() {
            //         Name="201",
            //     },
            //     new Curso() {
            //         Name="301"
            //     },
            // };
            Curso[] cursos = {
                new Curso {
                    Name="101",
                },
                new Curso {
                    Name="201",
                },
                new Curso {
                    Name="301"
                },
            };


            school.Cursos = cursos;
        }
        public static void jugandoList(School school) {
            var cursosList = new List<Curso>(){
                new Curso {
                    Name="401",
                },
                new Curso {
                    Name="501",
                },
                new Curso {
                    Name="601"
                },
            };
            school.ListCursos = cursosList;
            school.ListCursos.Add( new Curso { Name= "701", Jornada= TypesJornada.Mañana, });

            var cursosList2 = new List<Curso>(){
                new Curso {
                    Name="801",
                },
                new Curso {
                    Name="901",
                },
                new Curso {
                    Name="1001",
                }
            };
             var tmpp = new Curso { Name= "random", Jornada= TypesJornada.Noche }; 
            // cursosList2.Clear();
            
            cursosList2.Add(tmpp);
            cursosList2.Remove(tmpp);
            Predicate<Curso> verify = borrar;  //valida si cumple con la interfaz (no es necesario ya que existe la inferencia de types)
            school.ListCursos.RemoveAll(borrar); // un filter de js
            school.ListCursos.RemoveAll(delegate(Curso cur) { return cur.Name == "301"; }); //delegado
            school.ListCursos.RemoveAll( cur => cur.Name == "301"); //lambda
            school.ListCursos.AddRange(cursosList2);
            
            school.printListCursos();
        }

        private static bool borrar(Curso obj)
        {
            return obj.Name == "701"; 
        }
    } 
    class Sintaxis {
        // public string Name { get; set;}= "";
        

        void trash() {
                    // See https://aka.ms/new-console-template for more information

            // Console.WriteLine("Hello, World!");
            // int? age = null || System.Nullable<int>
            // var sintaxis = new Basic.Sintaxis() { Name = "Jonathan"};
            // Console.WriteLine(sintaxis.Name);

            // int age = default(int);
            // bool boolean = default(bool);
            // Int32 age2 = default(Int32);

            // var strings = "asd"; //var infiere tipo de dato en compilación
            // dynamic age3 = 10;//dynamic infiere tipo de dato en runtime acepta null

            // float flotante = (float)age; //casting implicito
            // float flotanteExplicito = age; //casting explicito

            // int entero = 10;
            // object objeto = (object)entero; //boxing explicito
            // int f = (int)objeto; // unboxing
            // Console.WriteLine(objeto); 
            // // int lala = (object)objeto;

            // Console.WriteLine(boolean);
            // Console.WriteLine(age);

            // Console.WriteLine("What is your name?");
            // string? name = Console.ReadLine();

            // var currentDate = DateTime.Now;
            // Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            // Console.Write($"{Environment.NewLine}Press any key to exit...{Environment.NewLine}");
            // Console.ReadKey(true);
        }
    }
}