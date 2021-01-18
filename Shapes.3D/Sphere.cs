using ShapeProcessor;

namespace Shapes3D
{
    [RegisterShape(SHAPE_NAME)]
    public sealed class Sphere : Base3DShape
    {
        public const string SHAPE_NAME = "Sphere";

        public Sphere()
        {
            this.Name = SHAPE_NAME;
            this.Vertices = 0;
        }

        public override string ovr_GetSurfaceArea()
        {
            return "4 * Pi * r ^ 2";
        }

        public override string ovr_GetVolume()
        {
            return "(4 / 3) * Pi * r ^ 3";
        }
    }
}
