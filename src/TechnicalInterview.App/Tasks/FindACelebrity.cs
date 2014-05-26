using System.Collections.Generic;

namespace TechnicalInterview.App.Tasks
{
    //Task:
    /*
     * You're hosting a party, you've invied some friends and some celebrities.
     * Each of your friends know each other, and the celebrities, but the 
     * celebrities only know themselves, find the celebrities.
     */

    public class Party
    {
        private IList<Person> PartyGoers { get; set; }

        public Party()
        {
            PartyGoers = new List<Person>();
        }

        public void StartParty()
        {
            var celeb1 = new Person("Alphonz");
            PartyGoers.Add(celeb1);

            var celeb2 = new Person("Brendan");
            PartyGoers.Add(celeb2);

            var pleb1 = new Person("Lucas");
            PartyGoers.Add(pleb1);

            var pleb2 = new Person("Tash");
            PartyGoers.Add(pleb2);

            var pleb3 = new Person("Jason");
            PartyGoers.Add(pleb3);
            
            var pleb4 = new Person("Troy");
            PartyGoers.Add(pleb4);
            
            var pleb5 = new Person("Staple");
            PartyGoers.Add(pleb5);

            foreach (var partyGoer in PartyGoers)
            {
                if (partyGoer == celeb1 || partyGoer == celeb2)
                    continue;

                partyGoer.SpotAcquaintance(celeb1);
                partyGoer.SpotAcquaintance(celeb2);
            }
        }

        public IList<Person> FindCelebrities()
        {
            var celebrities = new List<Person>();
            foreach (var partyGoer in PartyGoers)
            {
                if (partyGoer.IsCelebrity)
                    celebrities.Add(partyGoer);
            }

            return celebrities;
        }
    }

    public class Person
    {
        public string Name { get; private set; }
        public IList<Person> Acquaintances { get; private set; }

        public Person(string name)
        {
            Name = name;
            Acquaintances = new List<Person>();
        }

        public bool IsCelebrity
        {
            get { return Acquaintances.Count == 0; }
        }

        public void SpotAcquaintance(Person person)
        {
            Acquaintances.Add(person);
        }
    }
}
