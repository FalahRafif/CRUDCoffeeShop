#pragma checksum "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d7c15bacc58373cf84bdffb66511da99b29bde"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/coffeelist/{Id}")]
    public partial class CoffeeListUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Coffee</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-12");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListUpsert.razor"
                                 _coffee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListUpsert.razor"
                                                    SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "\r\n                        ");
                __builder2.AddMarkupContent(21, "<label>Id</label>\r\n                        ");
                __builder2.OpenElement(22, "input");
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "id", "id");
                __builder2.AddAttribute(26, "name", "id");
                __builder2.AddAttribute(27, "value", 
#nullable restore
#line 17 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListUpsert.razor"
                                                                                          _coffee.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(28, "disabled", true);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "\r\n                        ");
                __builder2.AddMarkupContent(34, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "id", "name");
                __builder2.AddAttribute(38, "name", "name");
                __builder2.AddAttribute(39, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListUpsert.razor"
                                                                                           _coffee.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _coffee.Name = __value, _coffee.Name))));
                __builder2.AddAttribute(41, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _coffee.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n");
#nullable restore
#line 24 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListUpsert.razor"
                     if (_pageMode == "edit")
                    { 

#line default
#line hidden
#nullable disable
                __builder2.AddContent(44, "                        ");
                __builder2.AddMarkupContent(45, "<button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n");
#nullable restore
#line 27 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListUpsert.razor"
                    }
                    else if (_pageMode == "new")
                    { 

#line default
#line hidden
#nullable disable
                __builder2.AddContent(46, "                        ");
                __builder2.AddMarkupContent(47, "<button type=\"submit\" class=\"btn btn-primary\">Insert</button>\r\n");
#nullable restore
#line 31 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListUpsert.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(48, "                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\Work\C#\NET_CORE\Cofiel\Pages\CoffeeList\CoffeeListUpsert.razor"
       
    [Parameter]
    public string Id { get; set; }

    private Coffee _coffee { get; set; }

    private string _pageMode = "new";

    protected override void OnInitialized()
    {
        if(!string.IsNullOrEmpty(Id) && Id.Equals("new"))
        {
            _coffee = new Coffee();
        }
        else
        {
            _pageMode = "edit";
            GetData();
        }

    }

    public void GetData()
    {
        try
        {
            _coffee = _coffeeService.GetCoffeeById(Guid.Parse(Id));
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void SubmitForm()
    {
        try
        {
            if (_pageMode == "edit")
            {
                _coffeeService.UpdateCoffee(_coffee);
                _navigation.NavigateTo("coffeelist");
            }
            else if (_pageMode == "new")
            {
                _coffeeService.InsertCoffee(_coffee);
                _navigation.NavigateTo("coffeelist");
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICoffeeService _coffeeService { get; set; }
    }
}
#pragma warning restore 1591