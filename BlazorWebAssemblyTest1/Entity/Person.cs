using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblyTest1.Entity;

public class Person
{
    [Key]
    public Guid Id { get; set; }
    
    public string FirstName { get; set; } = string.Empty;
    
    public Guid? HouseId { get; set; }
    public House? House { get; set; }
    
}