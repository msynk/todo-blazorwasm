using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Todo
{
    public static class CSB
    {
        public static async Task Focus(this ElementReference el)
        {
            var js = Program.ServiceProvider.GetService(typeof(IJSRuntime)) as IJSRuntime;
            await js.InvokeVoidAsync("csb.focus", el);
        }
    }
}