#pragma checksum "C:\pidiProjeto\LaBrasa\LaBrasa\Client\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9d5792cdfc85e17f2a435c24e47204df7cdfdc4"
// <auto-generated/>
#pragma warning disable 1591
namespace LaBrasa.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\_Imports.razor"
using LaBrasa.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\_Imports.razor"
using LaBrasa.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\Pages\FetchData.razor"
using LaBrasa.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .btn {
        border-radius: 0;
    }

    .btn-danger {
        border-radius: 100%;
    }

    .btn-primary, .btn-success {
        border-radius: 100%;
    }

    .float {
        position: absolute;
        right: 0;
        margin-right: 10px;
        top: 0;
        margin-top: 5px;
    }
</style>

");
            __builder.OpenElement(1, "div");
#nullable restore
#line 28 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\Pages\FetchData.razor"
     if (visibilidadePainel)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "input-group");
            __builder.AddMarkupContent(4, "<input class=\"form-control\" placeholder=\"Pesquisar...\">\r\n            ");
            __builder.AddMarkupContent(5, "<button class=\"btn btn-danger\" style=\"border-radius: 0!important\"><i class=\"oi oi-magnifying-glass\"></i></button>\r\n            ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-success");
            __builder.AddAttribute(8, "style", "margin-left: 25px;");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\Pages\FetchData.razor"
                                                                                 alterarVisibilidade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "<i class=\"oi oi-plus\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(11, "ul");
            __builder.AddAttribute(12, "class", "list-group mt-3");
            __builder.OpenElement(13, "li");
            __builder.AddAttribute(14, "class", "list-group-item");
            __builder.AddMarkupContent(15, "\r\n                Churrasco de jacaré ");
            __builder.AddMarkupContent(16, "<b>R$50,00</b>\r\n                ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "float");
            __builder.AddMarkupContent(19, "<button class=\"btn btn-danger\">X</button> ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-primary");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\Pages\FetchData.razor"
                                                                                                        EditarProduto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.AddMarkupContent(25, "<li class=\"list-group-item\">Dapibus ac facilisis in</li>\r\n            ");
            __builder.AddMarkupContent(26, "<li class=\"list-group-item\">Morbi leo risus</li>\r\n            ");
            __builder.AddMarkupContent(27, "<li class=\"list-group-item\">Porta ac consectetur ac</li>\r\n            ");
            __builder.AddMarkupContent(28, "<li class=\"list-group-item\">Vestibulum at eros</li>");
            __builder.CloseElement();
#nullable restore
#line 50 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\Pages\FetchData.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\Pages\FetchData.razor"
     if (visibilidadeForm)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "div");
            __builder.AddContent(30, 
#nullable restore
#line 55 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\Pages\FetchData.razor"
             tituloForm

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "form");
            __builder.AddMarkupContent(33, @"<div class=""row""><div class=""form-group col-8""><label for=""exampleInputEmail1"">Nome</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Nome""></div>
                <div class=""form-group col-4""><label for=""exampleInputEmail1"">Id</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Id""></div></div>

            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "row");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-group col-12");
            __builder.AddMarkupContent(38, "<label for=\"exampleFormControlSelect1\">Categoria</label>\r\n                    ");
            __builder.OpenElement(39, "select");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "id", "exampleFormControlSelect1");
            __builder.OpenElement(42, "option");
            __builder.AddContent(43, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "option");
            __builder.AddContent(46, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "option");
            __builder.AddContent(49, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                        ");
            __builder.OpenElement(51, "option");
            __builder.AddContent(52, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.OpenElement(54, "option");
            __builder.AddContent(55, "5");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n            ");
            __builder.AddMarkupContent(57, @"<div class=""row""><div class=""form-group col-6""><label for=""exampleInputEmail1"">Preço Custo</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Nome""></div>
                <div class=""form-group col-6""><label for=""exampleInputEmail1"">Preço Venda</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""Id""></div></div>

            ");
            __builder.AddMarkupContent(58, @"<div class=""row""><div class=""form-group col-4""><label for=""exampleInputEmail1"">Qtd Minima</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1""></div>
                <div class=""form-group col-4""><label for=""exampleInputEmail1"">Estoque</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1""></div>
                <div class=""form-group col-4""><label for=""exampleInputEmail1"">A adicionar</label>
                    <input type=""email"" class=""form-control"" id=""exampleInputEmail1""></div></div>

            ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "row");
            __builder.AddMarkupContent(61, "<button type=\"submit\" class=\"btn btn-outline-danger col-6\">Submit</button>\r\n                ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "btn btn-light col-6");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\Pages\FetchData.razor"
                                                              alterarVisibilidade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "Voltar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 113 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\pidiProjeto\LaBrasa\LaBrasa\Client\Pages\FetchData.razor"
       
    //private WeatherForecast[] forecasts;

    //protected override async Task OnInitializedAsync()
    //{
    //    forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    //}
    string tituloForm;
    bool visibilidadePainel = true;
    bool visibilidadeForm = false;

    private void alterarVisibilidade()
    {
        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Novo Produto";
    }

    private void EditarProduto()
    {
        visibilidadePainel = !visibilidadePainel;
        visibilidadeForm = !visibilidadeForm;
        tituloForm = "Editar Produto";
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591