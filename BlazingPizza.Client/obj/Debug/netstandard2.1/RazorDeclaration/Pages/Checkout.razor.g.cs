#pragma checksum "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/Pages/Checkout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6da4f7d7af49d7abead1c4f8f9df1e0b30c064a5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazingPizza.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#line 3 "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 4 "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 7 "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 8 "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/_Imports.razor"
using BlazingPizza.Client;

#line default
#line hidden
#line 9 "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/_Imports.razor"
using BlazingPizza.Client.Shared;

#line default
#line hidden
#line 10 "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/_Imports.razor"
using BlazingPizza.ComponentsLibrary;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkout")]
    public partial class Checkout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 24 "/Users/kp/Development/blazor-workshop/save-points/00-Starting-point/BlazingPizza.Client/Pages/Checkout.razor"
       
    async Task PlaceOrder()
    {
        var newOrderId = await HttpClient.PostJsonAsync<int>("orders", OrderState.Order);
        OrderState.ResetOrder();

        NavigationManager.NavigateTo($"myorders/{newOrderId}");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private OrderState OrderState { get; set; }
    }
}
#pragma warning restore 1591