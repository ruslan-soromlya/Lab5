
namespace Lab5.Logic.Realisations
{
    public interface IDataSerializer
    {
        IList<T> Deserialize<T>(string serializedData);
        string Serialize<T>(IList<T> data);
    }
}