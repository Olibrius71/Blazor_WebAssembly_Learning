namespace BlazorWebAssemblyTest1.Domain.House;

public interface IHouseService
{
    List<Entity.House> GetAllHousesWithPersons();
}