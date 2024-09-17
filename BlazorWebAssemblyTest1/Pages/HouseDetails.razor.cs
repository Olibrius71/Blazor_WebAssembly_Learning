using BlazorWebAssemblyTest1.Domain.House;
using BlazorWebAssemblyTest1.Entity;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyTest1.Pages;

public partial class HouseDetails : ComponentBase
{
    [Parameter]
    public Guid HouseId { get; set; }

    public House? House { get; set; }
    
    [Inject]
    private IHouseService houseService { get; set; }
    
    protected override void OnInitialized()
    {
        House = houseService.GetHouseByIdWithPersons(HouseId);
    }
}