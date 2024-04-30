using Microsoft.JSInterop;

namespace Nova.Components.Pages
{
    public partial class Home
    {
        string recordButton = "record";

        bool recording = false;
        bool notRecording = true;


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

        private void RecordB()
        {
            int x = 0;
        }
    }
}
