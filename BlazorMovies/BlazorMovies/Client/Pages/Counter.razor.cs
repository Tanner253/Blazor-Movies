using BlazorMovies.Shared.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonService singleton { get; set; }
        [Inject] TransientService transient { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private int currentCount = 0;
        private static int currentCountStatic = 0;
        private async Task IncrementCountJavaScript()
        {
          
            await js.InvokeVoidAsync("dotnetInstanceInvocation", DotNetObjectReference.Create(this));
        }
        [JSInvokable]
        public async Task IncrementCount()
        {
            currentCount++;
            transient.Value = currentCount;
            singleton.Value = currentCount;
            currentCountStatic++;
            await js.InvokeVoidAsync("dotnetStaticInvocation");

        }
        [JSInvokable]
        public static Task<int> GetCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
