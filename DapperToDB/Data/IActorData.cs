using DapperToDB.Models;

namespace DapperToDB.Data;

public interface IActorData
{
    List<string> GetUniqueNames();
    ActorModel? GetActorByID(int id);

    List<ActorNameAndLastName?> GetActorByLessThanFilms(int quantity);
}
