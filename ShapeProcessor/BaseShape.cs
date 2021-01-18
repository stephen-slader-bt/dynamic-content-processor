using LaunchProcessor.OutputClasses;
using System;
using System.Collections.Generic;

namespace ShapeProcessor
{
    public abstract class BaseShape
    {
        private static Dictionary<string, BaseShape> _registeredShapes;

        static BaseShape()
        {
            _registeredShapes = new Dictionary<string, BaseShape>();
        }

        public string Name { get; protected set; }
        public int Vertices { get; protected set; }

        #region Static Functions

        public static bool RegisterShape(string name, Type type)
        {
            if (_registeredShapes.ContainsKey(name))
                return false;

            BaseShape shape = (BaseShape) Activator.CreateInstance(type);

            _registeredShapes.Add(name, shape);

            return true;
        }

        public static bool OutputAllShapeInformation()
        {
            foreach (KeyValuePair<string, BaseShape> kvp in _registeredShapes)
            {
                kvp.Value.DisplayShapeInformation();
            }

            return true;
        }

        #endregion Static Functions

        public bool DisplayShapeInformation()
        {
            OutputManager.SendMessageToOutput($"=== Shape: [{this.Name}] ===");
            OutputManager.SendMessageToOutput($"  Vertices:  [{this.Vertices}]");
            return ovr_DisplayShapeInformation();
        }

        public abstract bool ovr_DisplayShapeInformation();
    }
}
