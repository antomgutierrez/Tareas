using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        public string SearchNumber(string name){
            var resultado = "";
            foreach (Contact contacto in this.persons)
            {
                if (contacto.Name.Equals(name))
                {
                    resultado = contacto.Phone;
                }                
            }
            return resultado;

        }

        public void add(Contact contacto)
        {
            this.persons.Add(contacto);
        }
    }
}