using LaunchProcessor.OutputClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace LaunchLoader
{
    public sealed class Program
    {
        /// <summary>
        /// Main application function.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            _LoadDynamicContent();
        }

        /// <summary>
        /// Loads all dynamic content for the application
        /// </summary>
        private static void _LoadDynamicContent()
        {
            List<DynamicContentProcessor> processors = new List<DynamicContentProcessor>();

            List<Assembly> assemblies = _LoadAssemblies();

            // First pass is to load the processors
            foreach (Assembly assembly in assemblies)
            {
                foreach (Type type in assembly.GetTypes())
                {
                    // Ignoring abstracts and interfaces
                    if (type.IsAbstract)
                        continue;
                    if (type.IsInterface)
                        continue;

                    // Ignoring all non-processor types
                    if (!typeof(DynamicContentProcessor).IsAssignableFrom(type))
                        continue;

                    DynamicContentProcessor processor = (DynamicContentProcessor)Activator.CreateInstance(type);

                    processors.Add(processor);
                }
            }

            // Second pass is to process the dynamic content
            foreach (Assembly assembly in assemblies)
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.IsAbstract)
                        continue;
                    if (type.IsInterface)
                        continue;

                    foreach (DynamicContentProcessor processor in processors)
                        processor.ProcessType(type);
                }
            }

            OutputManager.InitializeOutput();

            // Now do something with the processors.  (Not strictly needed, provided as an example.)
            foreach (DynamicContentProcessor processor in processors)
                processor.OutputContent();

            OutputManager.UninitializeOutput();
        }

        /// <summary>
        /// Loads all DLL files in the application folder.  Has basic error handling
        /// for libraries that are not .NET assemblies.
        /// </summary>
        /// <returns></returns>
        private static List<Assembly> _LoadAssemblies()
        {
            List<Assembly> assemblies = new List<Assembly>();

            string filePath = Assembly.GetExecutingAssembly().Location;
            int index = filePath.LastIndexOf("\\");
            filePath = filePath.Remove(index);

            foreach (string fileName in Directory.GetFiles(filePath))
            {
                try
                {
                    Assembly assembly = Assembly.LoadFile(fileName);

                    assemblies.Add(assembly);
                }
                catch (FileLoadException)
                {
                    continue;
                }
                catch (BadImageFormatException)
                {
                    continue;
                }
            }

            return assemblies;
        }

    }
}
