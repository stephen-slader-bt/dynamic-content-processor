using ShapeProcessor;

namespace Shapes3D
{
    [RegisterShape(SHAPE_NAME)]
    public sealed class Cube : Base3DShape
    {
        private const string SHAPE_NAME = "Cube";

        public Cube()
        {
            this.Name = SHAPE_NAME;
            this.Vertices = 8;
        }

        public override string ovr_GetSurfaceArea()
        {
            return "6 * (s ^ 2)";
        }

        public override string ovr_GetVolume()
        {
            return "s ^ 3";
        }
    }
}
