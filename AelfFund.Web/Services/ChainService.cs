using Microsoft.JSInterop;

namespace AelfFund.Web.Services
{
    public class ChainService
    {
        private readonly IJSRuntime JS;

        public ChainService(IJSRuntime js)
        {
            this.JS = js;
        }

        public async Task TestAsync()
        {
            await JS.InvokeVoidAsync("Test");
        }
    }
}
