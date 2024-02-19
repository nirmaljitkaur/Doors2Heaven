using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Doors2Heaven.Models;

public class DoorMaterialViewModel
{
    public List<Doors>? Doors { get; set; }
    public SelectList? Material { get; set; }
    public string? DoorMaterial { get; set; }
    public string? SearchString { get; set; }
}