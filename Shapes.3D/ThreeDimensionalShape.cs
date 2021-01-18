using LaunchProcessor.OutputClasses;
using ShapeProcessor;

namespace Shapes3D
{
    public abstract class Base3DShape : BaseShape
    {
        public override bool ovr_DisplayShapeInformation()
        {
            string surfaceArea = ovr_GetSurfaceArea();
            string volume = ovr_GetVolume();

            OutputManager.SendMessageToOutput($"  Surface Area: [{surfaceArea}]");
            OutputManager.SendMessageToOutput($"  Volume:       [{volume}]");

            return true;
        }

        public abstract string ovr_GetSurfaceArea();
        public abstract string ovr_GetVolume();
    }
}
