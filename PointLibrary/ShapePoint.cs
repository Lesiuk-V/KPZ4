using System.Windows.Controls;


namespace PointLibrary
{
    public struct pictureData
    {
        public int Point1X { get; set; }
        public int Point1Y { get; set; }
        public int Point2X { get; set; }
        public int Point2Y { get; set; }
        public int Point3X { get; set; }
        public int Point3Y { get; set; }
    }
    public class ShapePoint
    {

        protected pictureData _point;
        public ShapePoint()
        {

        }
        public virtual void drow(Grid grid)
        {

        }
    }
}