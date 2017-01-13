using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcLeassons.Models;

namespace MvcLeassons
{

    public static class DataRepository
    {

        private static Dictionary<int, Person> _peopleDictionary = new Dictionary<int, Person>();
        private static Dictionary<int, Country> _countriesDictionary = new Dictionary<int, Country>();
        private static Dictionary<int, State> _statesDictionary = new Dictionary<int, State>();
        private static Dictionary<int, City> _citiesDictionary = new Dictionary<int, City>();

        static DataRepository()
        {

            AddCountry(new Country() { Name = "Argentina" });
            AddCountry(new Country() { Name = "EEUU" });
            AddCountry(new Country() { Name = "Noruega" });
            AddCountry(new Country() { Name = "Chile" });
            AddCountry(new Country() { Name = "Venezuela" });
            AddCountry(new Country() { Name = "Brasil" });

            AddState(new State() { Name = "Tucumán", Country = _countriesDictionary[1] });
            AddState(new State() { Name = "Santiago del Estero", Country = _countriesDictionary[1] });
            AddState(new State() { Name = "Jujuy", Country = _countriesDictionary[1] });
            AddState(new State() { Name = "Buenos Aires", Country = _countriesDictionary[1] });

            AddCity(new City() { Name = "San Miguel de Tucumán", State = _statesDictionary[1] });
            AddCity(new City() { Name = "Alderetes", State = _statesDictionary[1] });
            AddCity(new City() { Name = "Banda del Río Salí", State = _statesDictionary[1] });
            AddCity(new City() { Name = "Concepción", State = _statesDictionary[1] });

            AddPerson(new Person() { FirstName = "Horario", LastName = "Lizarraga", Salary = 25000, BornDate = new DateTime(1970, 1, 20), City = _citiesDictionary[1] });
            AddPerson(new Person() { FirstName = "Fabián", LastName = "Orellana", Salary = 23700, BornDate = new DateTime(1975, 5, 27), City = _citiesDictionary[1] });
            AddPerson(new Person() { FirstName = "Enrique", LastName = "Pose", Salary = 20000, BornDate = new DateTime(1969, 12, 16), City = _citiesDictionary[1] });
            AddPerson(new Person() { FirstName = "Raúl", LastName = "Navarro", Salary = 22500, BornDate = new DateTime(1978, 10, 18), City = _citiesDictionary[1] });

        }

        internal static City GetCity(int id)
        {
            return _citiesDictionary[id];
        }

        public static Country GetCountry(int idCountry)
        {
            return _countriesDictionary[idCountry];
        }
        public static State GetCities(int idState)
        {
            
            return _statesDictionary[idState];
        }
        public static List<Person> GetAllPeople()
        {
            return _peopleDictionary.Values.ToList();
        }

        public static void AddPerson(Person p)
        {
            p.Id = _peopleDictionary.Keys.Count + 1;
            _peopleDictionary.Add(p.Id, p);
        }

        public static void AddCountry(Country c)
        {
            c.Id = _countriesDictionary.Keys.Count + 1;
            c.States = new List<State>();
            _countriesDictionary.Add(c.Id, c);
        }

        public static void AddState(State s)
        {
            s.Id = _statesDictionary.Keys.Count + 1;
            s.Country.States.Add(s);
            s.Cities = new List<City>();
            _statesDictionary.Add(s.Id, s);
        }

        public static void AddCity(City c)
        {
            c.Id = _citiesDictionary.Keys.Count + 1;
            c.State.Cities.Add(c);
            _citiesDictionary.Add(c.Id, c);
        }

        public static void EditPerson(Person p)
        {
            _peopleDictionary[p.Id] = p;
        }

        public static void DeletePerson(Person p)
        {
            _peopleDictionary.Remove(p.Id);
        }

        public static Person GetPerson(int id)
        {
            if (_peopleDictionary.ContainsKey(id))
                return _peopleDictionary[id];
            else
                return null;
        }

        internal static dynamic GetAllCountries()
        {
            return _countriesDictionary.Values.ToList();
        }
    }

}
