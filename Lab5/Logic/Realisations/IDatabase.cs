using Lab5.Models;

namespace Lab5.Logic.Realisations
{
    public interface IDatabase
    {
        void ChangeDbPath(string dbPath);
        IList<Contact> LoadContacts();
        void SaveDatabase(IEnumerable<Contact> contacts);
        string GetCurrentDbPath();
        void ResetDatabase();
    }
}