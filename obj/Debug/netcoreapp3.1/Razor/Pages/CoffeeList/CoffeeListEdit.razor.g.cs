#pragma checksum "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41d58e6dc2fad5ca7975c457da93901692cab480"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/coffeelist{id}")]
    public partial class CoffeeListEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Coffee</h3>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Edit ");
            __builder.AddContent(3, 
#nullable restore
#line 4 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListEdit.razor"
         Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListEdit.razor"
       
    public string Id { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
