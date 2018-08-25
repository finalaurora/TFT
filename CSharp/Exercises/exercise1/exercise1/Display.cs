using System;
namespace exercise1
{
    internal class Display
    {
        int Height { get; set; }
        int Width { get; set; }
        double Size { get; set; }
        Int32 NumOfColors { get; set; }
        public Display()
        {
            this.Height = 0;
            this.Width = 0;
            this.Size = 0;
            this.NumOfColors = 0;
        }

        public Display(int width, int height,double size,Int32 numOfColors)
        {
            Height = height;
            Width = width;
            Size = size;
            NumOfColors = numOfColors;
        }

        public override string ToString()
        {
            return "\nDisplay Size: "+this.Size+" inch(es)"
                +"\nResolution: "+this.Width+"x"+this.Height+" pixels"
                +"\nNumber of Colors: "+this.NumOfColors/1000000+"M"+" Colors";
        }
    }
}