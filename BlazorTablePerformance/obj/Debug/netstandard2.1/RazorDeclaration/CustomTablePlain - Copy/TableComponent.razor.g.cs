#pragma checksum "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTablePlain - Copy\TableComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cc5d02c979af0568987a47be36bb1329200bd85"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorTablePerformance.CustomTablePlain___Copy
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\_Imports.razor"
using BlazorTablePerformance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\_Imports.razor"
using BlazorTablePerformance.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\_Imports.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    public partial class TableComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTablePlain - Copy\TableComponent.razor"
       
    [Parameter]
    public WeatherForecast[] Data { get; set; }

    [Parameter]
    public List<string> Columns { get; set; }

    Task RefreshComponent(int index)
    {
        StateHasChanged();

        return Task.CompletedTask;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
