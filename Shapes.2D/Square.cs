using ShapeProcessor;

namespace Shapes2D
{
    [RegisterShape(SHAPE_NAME)]
    public sealed class Square : Base2DShape
    {
        public const string SHAPE_NAME = "Square";

        public Square()
        {
            this.Name = SHAPE_NAME;
            this.Vertices = 4;
        }

        public override string ovr_GetAreaText()
        {
            return "s ^ 2";
        }

        public override string ovr_GetPerimeterText()
        {
            return "s * 4";
        }
    }
}
