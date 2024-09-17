using BlazorWebAssemblyTest1.Entity;
using BlazorWebAssemblyTest1.Pages;

namespace BlazorWebAssemblyTest1.Domain.House;

public class HouseService : IHouseService
{
    private List<Entity.House> HousesList = new List<Entity.House>
    {
        new Entity.House
        {
            Id = Guid.NewGuid(),
            Address = "123 Maple Street",
            Rent = 1200.50f,
            Persons = new List<Person>
            {
                new Person { Id = Guid.NewGuid(), FirstName = "John" },
                new Person { Id = Guid.NewGuid(), FirstName = "Jane" }
            }
        },
        new Entity.House
        {
            Id = Guid.NewGuid(),
            Address = "456 Oak Avenue",
            Rent = 1500.75f,
            Persons = new List<Person>
            {
                new Person { Id = Guid.NewGuid(), FirstName = "Alice" },
                new Person { Id = Guid.NewGuid(), FirstName = "Bob" }
            }
        },
        new Entity.House
        {
            Id = Guid.NewGuid(),
            Address = "789 Pine Road",
            Rent = 1000.00f,
            Persons = new List<Person>
            {
                new Person { Id = Guid.NewGuid(), FirstName = "Charlie" }
            }
        }
    };

    
    public List<Entity.House> GetAllHousesWithPersons()
    {
        return HousesList;
    }
    
    public Entity.House? GetHouseByIdWithPersons(Guid houseId)
    {
        return HousesList.Find(house => house.Id == houseId);
    }
}