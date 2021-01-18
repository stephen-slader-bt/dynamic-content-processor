using ShapeProcessor;

namespace Shapes2D
{
    [RegisterShape(SHAPE_NAME)]
    public sealed class RightTriangle : Base2DShape
    {
        public const string SHAPE_NAME = "Right Triangle";
        public RightTriangle()
        {
            this.Name = SHAPE_NAME;
            this.Vertices = 3;
        }

        public override string ovr_GetAreaText()
        {
            return "b * h / 2";
        }

        public override string ovr_GetPerimeterText()
        {
            return "b + h + sqrt(b ^ 2 + h ^ 2)";
        }
    }
}
