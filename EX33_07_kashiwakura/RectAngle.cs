using EX33;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX33
{
    class RectAngle : ISurface, ICircumference, IBounds
    {
        readonly public float width;
        readonly public float height;
        public RectAngle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public float GetSurface()
        {
            return width * height;
        }
        public float GetCircumference()
        {
            return (width + height) * 2;
        }
        public void GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
        }
        public static bool operator ==(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }

        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return !(rectAngle1 == rectAngle2);
        }

        public static RectAngle operator +(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            RectAngle choice1, choice2;
            choice1 = new RectAngle(MathF.Max(rectAngle1.width, rectAngle2.width), rectAngle1.height + rectAngle2.height);
            choice2 = new RectAngle(rectAngle1.width + rectAngle2.width, MathF.Max(rectAngle1.height, rectAngle2.height));
            return choice1.width * choice1.height < choice2.width * choice2.height ? choice1 : choice2;
            //if(choice1.width * choice1.height < choice2.width * choice2.height)
            //{
            //    return choice1;
            //}
            //else
            //{
            //    return choice2;
            //}
        }
    }
}
