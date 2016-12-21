using System;

namespace ASI.ES.SkillUp.Shape
{
    /// <summary>
    /// Derived Class:Rectangle(Base is Shape)
    /// Necessary functions
    /// ・Area calculation（Parameterised function）
    /// ・Function to display the class name (override)（for debugging）
    /// </summary>
    class Rectangle : Shape
    {
        #region Properties
        /// <summary>
        /// For set and get value for left side of rectangle.
        /// </summary>
        public double Left { get; set; }

        /// <summary>
        /// For set and get value for right side of rectangle.
        /// </summary>
        public double Right { get; set; }

        /// <summary>
        /// For set and get value for bottom side of rectangle.
        /// </summary>
        public double Bottom { get; set; }

        /// <summary>
        /// For set and get value for top side of rectangle.
        /// </summary>
        public double Top { get; set; }

        /// <summary>
        /// For get value for rectangle height.
        /// </summary>
        public double Height
        {
            get
            {
                return Math.Abs(Top - Bottom);
            }
        }

        /// <summary>
        /// For get value for rectangle width.
        /// </summary>
        public double Width
        {
            get
            {
                return Math.Abs(Left - Right);
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public Rectangle() { }

        /// <summary>
        /// Parameterize constructor for initialize top, bottom, left and right
        /// </summary>
        /// <param name="dblTop">Double type, to set top</param>
        /// <param name="dblBottom">Double type, to set bottom</param>
        /// <param name="dblLeft">Double type, to set left</param>
        /// <param name="dblRight">Double type, to set right</param>
        public Rectangle(double dblTop, double dblBottom, double dblLeft, double dblRight)
        {
            Top = dblTop;
            Bottom = dblBottom;
            Left = dblLeft;
            Right = dblRight;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Override method of Shape class for calculate area.
        /// </summary>
        /// <returns>Double type, return calculated area</returns>
        public override double CalculateArea()
        {
            //Area equation of rectangle : A * B
            return Math.Abs(Height * Width);
        }

        /// <summary>
        /// Override method of Shape class for calculate perimeter.
        /// </summary>
        /// <returns>Double type, calculated perimeter</returns>
        public override double CalculatePerimeter()
        {
            //Perimeter equation of rectangle : 2 * A * B
            return Math.Abs(2.0 * (Height + Width));
        }

        /// <summary>
        /// Display class name
        /// </summary>
        public override void DisplayClassName()
        {
            //Display class name
            Console.WriteLine(this.GetType().Name);
        }
        #endregion
    }
}