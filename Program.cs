// using CoreSchool.Entities;
// var schoolLegacy = new School("university Jonas", "av. siempreviva 123", 1900, "argentina", "Buenos Aires", TypesSchool.primaria);
// Tanteador.jugandoList(schoolLegacy);
// Tanteador.jugandoArray(schoolLegacy);
using CoreEscuela;

var engine = new EscuelaEngine();

engine.Inicializar();

engine?.Escuela?.printListCursos();


