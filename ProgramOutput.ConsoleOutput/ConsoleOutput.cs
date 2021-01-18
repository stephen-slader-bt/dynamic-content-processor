using LaunchProcessor.OutputClasses;
using System;

namespace ProgramOutput.ConsoleOutput
{
    [RegisterOutput(OUTPUT_NAME_CONSOLE)]
    public sealed class ConsoleOutput : OutputType
    {
        private const string OUTPUT_NAME_CONSOLE = "Console";

        protected override void ovr_InitializeOutput()
        {
            Console.WriteLine("---  Output Initialization  ---");
        }

        protected override void ovr_OutputText(string text)
        {
            Console.WriteLine(text);
        }

        protected override void ovr_UninitializeOutput()
        {
            Console.WriteLine("---  Output Uninitialization  ---");
        }
    }
}
