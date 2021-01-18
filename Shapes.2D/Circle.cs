using ShapeProcessor;

namespace Shapes2D
{
    [RegisterShape(SHAPE_NAME)]
    public sealed class Sphere : Base2DShape
    {
        public const string SHAPE_NAME = "Circle";

        public Sphere()
        {
            this.Name = SHAPE_NAME;
            this.Vertices = 0;
        }

        public override string ovr_GetAreaText()
        {
            return "2 * Pi * r";
        }

        public override string ovr_GetPerimeterText()
        {
            return "Pi * r ^ 2";
        }
    }
}
