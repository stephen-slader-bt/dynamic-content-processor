using LaunchProcessor.OutputClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramOutput.FileOutput
{
    [RegisterOutput(OUTPUT_NAME)]
    public sealed class FileOutput : OutputType
    {
        public const string OUTPUT_NAME = "FileOutput";

        private List<string> _output;

        protected override void ovr_InitializeOutput()
        {
            _output = new List<string>();
        }

        protected override void ovr_OutputText(string text)
        {
            _output.Add(text);
        }

        protected override void ovr_UninitializeOutput()
        {
            string fileName = OUTPUT_NAME + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".txt";

            try
            {
                File.WriteAllLines(fileName, _output);
            }
            catch (Exception ex)
            { }
        }
    }
}
