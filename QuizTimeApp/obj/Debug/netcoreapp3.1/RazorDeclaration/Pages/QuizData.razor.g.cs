#pragma checksum "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\Pages\QuizData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c3767f27dc0329abbf213f5f7d123d9538fbede"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace QuizTimeApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\_Imports.razor"
using QuizTimeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\_Imports.razor"
using QuizTimeApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\_Imports.razor"
using QuizTimeApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/QuizTime")]
    public partial class QuizData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\klt\Source\Repos\FunProjects\QuizTimeApp\Pages\QuizData.razor"
       
    QuizDataModel[] quizTime;
    string errorString;

    protected override async Task OnInitializedAsync()
    {
        var request = new HttpRequestMessage(HttpMethod.Get,
            "https://storage.googleapis.com/blazor-test-crap/data.json");

        var client = _clientFactory.CreateClient();

        HttpResponseMessage response = await client.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            quizTime = await response.Content.ReadFromJsonAsync<QuizDataModel[]>();
        }
        else
        {
            errorString = $"There was an error getting our forecast: { response.ReasonPhrase }";
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591
