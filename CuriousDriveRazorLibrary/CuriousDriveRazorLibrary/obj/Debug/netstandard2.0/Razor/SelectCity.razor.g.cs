#pragma checksum "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "190576477a2a42e8da595ccd5da4ea0e4fe8edb1"
// <auto-generated/>
#pragma warning disable 1591
namespace CuriousDriveRazorLibrary
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public class SelectCity : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "select");
            __builder.AddAttribute(1, "class", "form-control col-3");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 4 "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor"
               CurrentCity

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentCity = __value, CurrentCity));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(4, "\r\n");
#line 5 "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor"
     if (@Cities != null)
    {

#line default
#line hidden
            __builder.AddContent(5, "        ");
            __builder.OpenElement(6, "option");
            __builder.AddAttribute(7, "value", true);
            __builder.AddContent(8, "select city..");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#line 8 "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor"
         foreach (var city in Cities)
        {

#line default
#line hidden
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "option");
            __builder.AddAttribute(12, "value", 
#line 10 "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor"
                            city

#line default
#line hidden
            );
            __builder.AddContent(13, 
#line 10 "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor"
                                   city

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
#line 11 "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor"
        }

#line default
#line hidden
#line 11 "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor"
         
    }

#line default
#line hidden
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 15 "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\SelectCity.razor"
       

    [Parameter]
    public string CurrentCity { get; set; }

    public string[] Cities { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && Cities == null)
        {
            Cities = await JSRuntime.InvokeAsync<string[]>("getCities");

            StateHasChanged();
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591