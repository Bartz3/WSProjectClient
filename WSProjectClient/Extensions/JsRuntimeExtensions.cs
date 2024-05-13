using Microsoft.JSInterop;

namespace WSProjectClient.Extensions
{
    public static class JsRuntimeExtensions
    {
        public static ValueTask ToastrSuccess(this IJSRuntime jsRuntime,string message)
            => jsRuntime.InvokeVoidAsync("ShowToastr", "success", message);

        public static ValueTask ToastrError(this IJSRuntime jsRuntime, string message)
            => jsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
    }
}
