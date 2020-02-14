#pragma checksum "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62d3ba8457a3fdf243b453d9d9a7ec2db703e88b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTablePerformance.CustomTableAttributes
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
    public partial class Cell : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "td");
            __builder.AddMultipleAttributes(1, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#nullable restore
#line 2 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
                  Attributes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
                () => OnClick.Invoke(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 4 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
     switch (Field)
    {
        case "Date":
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 7 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
             Item.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
                                          
            break;
        case "TemperatureC":
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 10 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
             Item.TemperatureC

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 10 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
                              
            break;
        case "TemperatureF":
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 13 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
             Item.TemperatureF

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 13 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
                              
            break;
        case "Summary":
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, 
#nullable restore
#line 16 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
             Item.Summary

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 16 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
                         
            break;
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Home PC\source\repos\BlazorTablePerformance\BlazorTablePerformance\CustomTableAttributes\Cell.razor"
       
    [Parameter]
    public WeatherForecast Item { get; set; }

    [Parameter]
    public string Field { get; set; }

    [Parameter]
    public Func<int, Task> OnClick { get; set; }

    private protected Dictionary<string, object> Attributes
    {
        get
        {
            var attributes = new Dictionary<string, object>();

            attributes["tabindex"] = 1;

            return attributes;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
