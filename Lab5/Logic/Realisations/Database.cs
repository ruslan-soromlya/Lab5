using Bogus;
using Lab5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Logic.Realisations
{
    internal class ContactsBindingList : BindingList<Contact>
    {
        public ContactsBindingList(IEnumerable<Contact> contacts)
        {
            FillContacts(contacts);
        }

        private void FillContacts(IEnumerable<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Items.Add(contact);
            }
        }
    }

    public class Database : IDatabase
    {
        private const string defaultDbPath = "lab5_db.txt";

        private readonly IDataSerializer _serializer;

        private string _currentDbPath;

        public Database(IDataSerializer dataSerializer)
        {
            _serializer = dataSerializer;
            _currentDbPath = defaultDbPath;

            EnsureCreated();
        }



        public IList<Contact> LoadContacts()
        {
            return _serializer.Deserialize<Contact>(File.ReadAllText(_currentDbPath));
        }

        public void SaveDatabase(IEnumerable<Contact> contacts)
        {
            File.WriteAllText(_currentDbPath, _serializer.Serialize(contacts.ToList()));
        }

        public void ChangeDbPath(string dbPath)
        {
            _currentDbPath = dbPath;
        }

        public string GetCurrentDbPath()
        {
            return _currentDbPath;
        }

        public void ResetDatabase()
        {
            File.Delete(defaultDbPath);
            EnsureCreated();
            ChangeDbPath(defaultDbPath);
        }

        private void EnsureCreated()
        {
            if (!File.Exists(_currentDbPath))
            {
                CreateDatabase();
            }
        }

        private void CreateDatabase()
        {
            //Randomizer.Seed = new Random(8675309);
            var ids = 1;
            var contancts = new Faker<Contact>("uk")
                 .StrictMode(true)
                 .RuleFor(x => x.Id, x => ids++)
                 .RuleFor(x => x.FirstName, x => x.Person.FirstName)
                 .RuleFor(x => x.LastName, x => x.Person.LastName)
                 .RuleFor(x => x.Address, x => x.Address.FullAddress())
                 .RuleFor(x => x.PhoneNumber, x => x.Phone.PhoneNumber("032-###-##-##"))
                 .RuleFor(x => x.MobilePhoneNumber, x => x.Phone.PhoneNumber("+380 9# ###-##-##"))
                 .RuleFor(x => x.Email, x => x.Person.Email)
                 .Generate(30);

            var serializer = new DataSerializer();
            File.WriteAllText(_currentDbPath, serializer.Serialize(contancts));
        }
    }

    public class DataSerializer : IDataSerializer
    {
        public string Serialize<T>(IList<T> data)
        {
            return System.Text.Json.JsonSerializer.Serialize(data);
        }

        public IList<T> Deserialize<T>(string serializedData)
        {
            return System.Text.Json.JsonSerializer.Deserialize<IList<T>>(serializedData);
        }
    }


}
