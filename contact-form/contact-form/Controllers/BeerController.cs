namespace WebForms
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using System.Net.Http;
	using System.Web.Http;

	public class BeerController : ApiController
	{
        // Mock data
        Person[] Personals = new Person[]
		{
            new Person { Id = 1, Name = "Tomas Smetka", Beer = 2, Sex = "male"},
			new Person { Id = 2, Name = "Homer Simpson", Beer = 3, Sex = "female"},
            new Person { Id = 3, Name = "Barney Gumble", Beer = 5, Sex = "male"},
			new Person { Id = 10, Name = "Vocko", Beer = 10, Sex = "male"}
		};

        // Interface to @Person array
        public IEnumerable<Person> GetAllPersonals()
		{
            return Personals;
		}

        // Get all personals by ID
		public Person GetPersonalsById(int id)
		{
            var person = Personals.FirstOrDefault((p) => p.Id == id);
			if (person == null) // check exist 
			{
				throw new HttpResponseException(HttpStatusCode.NotFound); // not found
			}
			return person; // return personals order by ID
		}

        public IEnumerable<Person> GetPersonalByBeer(string personals) //filter
		{
			return Personals.Where(  
                (p) => string.Equals(p.Name, personals,
					StringComparison.OrdinalIgnoreCase));
		}
	}
}