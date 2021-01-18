using System;
using System.Collections.Generic;

namespace LaunchProcessor.OutputClasses
{
    public static class OutputManager
    {
        private static Dictionary<string, OutputType> _registeredOutputTypes;

        static OutputManager()
        {
            _registeredOutputTypes = new Dictionary<string, OutputType>();
        }

        public static bool RegisterOutputType(string name, Type type)
        {
            if (_registeredOutputTypes.ContainsKey(name))
                return false;

            OutputType output = (OutputType) Activator.CreateInstance(type);
            _registeredOutputTypes.Add(name, output);

            return true;
        }

        public static void SendMessageToOutput(string message)
        {
            foreach (KeyValuePair<string, OutputType> kvp in _registeredOutputTypes)
                kvp.Value.OutputText(message);
        }

        public static void InitializeOutput()
        {
            foreach (KeyValuePair<string, OutputType> kvp in _registeredOutputTypes)
                kvp.Value.InitializeOutput();
        }

        public static void UninitializeOutput()
        {
            foreach (KeyValuePair<string, OutputType> kvp in _registeredOutputTypes)
                kvp.Value.UninitializeOutput();
        }
    }
}
