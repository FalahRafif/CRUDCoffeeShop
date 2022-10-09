#pragma checksum "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f12da4af55d6327b46d37f96be1a7278cf465991"
// <auto-generated/>
#pragma warning disable 1591
namespace Cofiel.Pages.CoffeeList
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using Cofiel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using Cofiel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using Cofiel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using Cofiel.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Work\C#\NET_CORE\Cofiel\_Imports.razor"
using Cofiel.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/coffeelist")]
    public partial class CoffeeList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-12");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h3>Coffee List</h3>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddMarkupContent(16, @"<thead class=""thead-dark"">
                        <tr>
                            <th scope=""col"">Id</th>
                            <th scope=""col"">Name</th>
                            <th scope=""col"">Action</th>
                        </tr>
                    </thead>
                    ");
            __builder.OpenElement(17, "tbody");
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 20 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeList.razor"
                         if (_coffees.Count() > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeList.razor"
                             foreach (var coffee in _coffees)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "                                ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\r\n                                    ");
            __builder.OpenElement(22, "th");
            __builder.AddAttribute(23, "scope", "row");
            __builder.AddContent(24, 
#nullable restore
#line 25 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeList.razor"
                                                     coffee.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 26 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeList.razor"
                                         coffee.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                    ");
            __builder.OpenElement(29, "td");
            __builder.AddMarkupContent(30, "\r\n                                        ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "class", "btn btn-warning");
            __builder.AddAttribute(33, "href", "coffeelist/" + (
#nullable restore
#line 28 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeList.razor"
                                                                                     coffee.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(34, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 31 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeList.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeList.razor"
                             
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeList.razor"
       
    private List<Coffee> _coffees;

    protected override void OnInitialized()
    {
        _coffees = _coffeeService.GetCoffees();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICoffeeService _coffeeService { get; set; }
    }
}
#pragma warning restore 1591
