#pragma checksum "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\PlainTableComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9640b430f7d2c51ce58134bf7e0635009dcf00a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTablePerformance.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/plain-table-component")]
    public partial class PlainTableComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>20 x 200 Grid</h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\PlainTableComponent.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 9 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\PlainTableComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenComponent<BlazorTablePerformance.CustomTablePlain.TableComponent>(4);
            __builder.AddAttribute(5, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTablePerformance.Shared.WeatherForecast[]>(
#nullable restore
#line 12 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\PlainTableComponent.razor"
                                                                   forecasts

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "Columns", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<System.String>>(
#nullable restore
#line 12 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\PlainTableComponent.razor"
                                                                                        Columns

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 13 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\PlainTableComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\PlainTableComponent.razor"
       
    private WeatherForecast[] forecasts;
    public List<string> Columns { get; set; } = new List<string>
{ "Date", "TemperatureC", "TemperatureF", "Summary", "Date", "TemperatureC", "TemperatureF", "Summary", "Date", "TemperatureC",
      "Date", "TemperatureC", "TemperatureF", "Summary", "Date", "TemperatureC", "TemperatureF", "Summary", "Date", "TemperatureC" };

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
