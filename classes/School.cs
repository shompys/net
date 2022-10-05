namespace CoreSchool.Entities {

    class School {
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

        // public School(string name, string address, int yearCreated, string country, string city) {
        //     this.name = name;
        //     this.address = address;
        //     this.YearCreated = yearCreated;
        //     this.Country = country;
        //     this.City = city;
        // }
        public School(string name, string address, int yearCreated, string country, string city
        ) => (Name, Address, YearCreated, Country, City) = (name, address, yearCreated, country, city);

        public void Timbrar() {
            Console.WriteLine($"Riiing");
        }
    }
}
