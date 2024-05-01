using Microsoft.JSInterop;
using Microsoft.VisualBasic;
using System.Security.Cryptography.Xml;

namespace Nova.Components.Pages
{
    public partial class Home
    {
        string recordButton = "record";

        bool recording = false;
        bool notRecording = true;
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            var objRef = DotNetObjectReference.Create(this);
            await jsRuntime.InvokeAsync<string>("setDotNetRef", [objRef]);
        }

        [JSInvokable]
        public void ReceiveDataFromJavaScript(object data)
        {
            // Process the received data
            Console.WriteLine("Data received in Blazor:", data.ToString());
        }

        private async Task Record()
        {

            recordButton = "recording";
            recording = true;
            notRecording = false;
            await jsRuntime.InvokeVoidAsync("MyJSMethods.startRecording");
        }

        private async Task Stop()
        {
            recordButton = "record";
            recording = false;
            notRecording = true;
            await jsRuntime.InvokeVoidAsync("MyJSMethods.stopRecording");
        }

        //private async Task RecordB()
        //{
            //var objRef = DotNetObjectReference.Create(this);
            //var result = await jsRuntime.InvokeAsync<string>("sendData");
            //Console.Write(result);
        //}
    }
}
