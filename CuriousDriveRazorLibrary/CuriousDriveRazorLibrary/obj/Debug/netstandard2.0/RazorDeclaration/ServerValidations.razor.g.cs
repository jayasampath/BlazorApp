#pragma checksum "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\ServerValidations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88e361c3d46f31908ce510c137358d4308baf283"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public class ServerValidations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 28 "C:\Data\CuriousDrive\BlazorApp\CuriousDriveRazorLibrary\CuriousDriveRazorLibrary\ServerValidations.razor"
       
    [Parameter]
    public bool IsVisible { get; set; }

    [Parameter]
    public bool Result { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        //Result = false; ///authorService.CheckConnection();
        //IsVisible = true;
        await base.OnParametersSetAsync();
    }

    private void CloseValidation()
    {
        IsVisible = false;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
