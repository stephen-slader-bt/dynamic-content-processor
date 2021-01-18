using LaunchProcessor.OutputClasses;
using ShapeProcessor;

namespace Shapes2D
{
    public abstract class Base2DShape : BaseShape
    {
        public override bool ovr_DisplayShapeInformation()
        {
            string perimeter = ovr_GetPerimeterText();
            string area = ovr_GetAreaText();

            OutputManager.SendMessageToOutput($"  Perimeter: [{perimeter}]");
            OutputManager.SendMessageToOutput($"  Area:      [{area}]");

            return true;
        }

        public abstract string ovr_GetPerimeterText();
        public abstract string ovr_GetAreaText();
    }
}
