#pragma checksum "C:\Users\Admin\source\repos\WebProjekti\WebProjekti\Views\Account\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76e530dc76f2df555ebf36e8e50cf0e3d4774ded"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebProjekti.Views.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Admin\source\repos\WebProjekti\WebProjekti\Views\Account\Register.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Admin\source\repos\WebProjekti\WebProjekti\Views\Account\Register.razor"
       
    RegisterViewModel emp = new RegisterViewModel();
    public async void Create()
    {
       var result = await Http.PostAsJsonAsync("https://localhost:44376/api/trips/RegisterUser", emp);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
