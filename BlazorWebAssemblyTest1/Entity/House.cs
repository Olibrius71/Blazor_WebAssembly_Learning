using System.ComponentModel.DataAnnotations;

namespace BlazorWebAssemblyTest1.Entity;

public class House
{
    [Key]
    public Guid Id { get; set; }
    
    public string Address { get; set; } = string.Empty;
    
    public float Rent { get; set; }
    
    public List<Person> Persons { get; set; }
}