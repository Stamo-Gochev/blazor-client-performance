#pragma checksum "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\TelerikComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a3b955d42781b60b5fe7147f72f241955c0da74"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/telerik-grid")]
    public partial class TelerikComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>20 x 200 Grid</h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\TelerikComponent.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 9 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\TelerikComponent.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __Blazor.BlazorTablePerformance.Pages.TelerikComponent.TypeInference.CreateTelerikGrid_0(__builder, 4, 5, 
#nullable restore
#line 12 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\TelerikComponent.razor"
                        forecasts

#line default
#line hidden
#nullable disable
            , 6, 
#nullable restore
#line 12 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\TelerikComponent.razor"
                                                  GridSelectionMode.Single

#line default
#line hidden
#nullable disable
            , 7, (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(9);
                __builder2.AddAttribute(10, "Field", "Date");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(12);
                __builder2.AddAttribute(13, "Field", "TemperatureC");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(15);
                __builder2.AddAttribute(16, "Field", "TemperatureF");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(18);
                __builder2.AddAttribute(19, "Field", "Summary");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(21);
                __builder2.AddAttribute(22, "Field", "Date");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(24);
                __builder2.AddAttribute(25, "Field", "TemperatureC");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(27);
                __builder2.AddAttribute(28, "Field", "TemperatureF");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(30);
                __builder2.AddAttribute(31, "Field", "Summary");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(33);
                __builder2.AddAttribute(34, "Field", "Date");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(36);
                __builder2.AddAttribute(37, "Field", "TemperatureC");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(39);
                __builder2.AddAttribute(40, "Field", "Date");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(42);
                __builder2.AddAttribute(43, "Field", "TemperatureC");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(45);
                __builder2.AddAttribute(46, "Field", "TemperatureF");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(48);
                __builder2.AddAttribute(49, "Field", "Summary");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(51);
                __builder2.AddAttribute(52, "Field", "Date");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(54);
                __builder2.AddAttribute(55, "Field", "TemperatureC");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(57);
                __builder2.AddAttribute(58, "Field", "TemperatureF");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(60);
                __builder2.AddAttribute(61, "Field", "Summary");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(63);
                __builder2.AddAttribute(64, "Field", "Date");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\r\n            ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(66);
                __builder2.AddAttribute(67, "Field", "TemperatureC");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 36 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\TelerikComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\Pages\TelerikComponent.razor"
       
    private WeatherForecast[] forecasts;

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
namespace __Blazor.BlazorTablePerformance.Pages.TelerikComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Telerik.Blazor.GridSelectionMode __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "SelectionMode", __arg1);
        __builder.AddAttribute(__seq2, "GridColumns", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
