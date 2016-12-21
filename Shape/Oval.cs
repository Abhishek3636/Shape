using System;

namespace ASI.ES.SkillUp.Shape
{
    /// <summary>
    /// Derived Class：Oval(Base is Shape)
    /// Necessary functions
    /// ・Area calculation（Parameterised function)
    /// ・Function to display the class name (override)（for debugging）
    /// </summary>
    class Oval : Shape
    {
        #region Properties
        /// <summary>
        /// For set and get property value for major axis of oval.
        /// </summary>
        public double MajorAxis { get; set; }

        /// <summary>
        /// For set and get property value for minor axis of oval.
        /// </summary>
        public double MinorAxis { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public Oval(){}

        /// <summary>
        /// Parameterize constructor for initialize major axis and minor axis
        /// </summary>
        /// <param name="dblMajorAxis">Double type, to set major axis</param>
        /// <param name="dblMinorAxis">Double type, to set minor axis</param>
        public Oval(double dblMajorAxis, double dblMinorAxis)
        {
            MajorAxis = dblMajorAxis;
            MinorAxis = dblMinorAxis;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Override method from Shape class for calculate area
        /// </summary>
        /// <returns>Double type, return area of oval</returns>
        public override double CalculateArea()
        {
            //Area equation of oval : PI * A * B
             return MajorAxis * MinorAxis * Math.PI;
        }

        //// <summary>
        /// Override method of Shape class for calculate perimeter
        /// </summary>
        /// <returns>Double type, return perimeter of oval</returns>
        public override double CalculatePerimeter()
        {
            //For store a temporary value of equation
            double dblTempResut;

            //Calculation of oval perimeter
            //Perimeter equation of oval : 2 * PI * square root(square(A) * square(B)/ 2);
            dblTempResut = (2 * Math.PI);
            dblTempResut *=  Math.Sqrt ((MajorAxis * MajorAxis + MinorAxis * MinorAxis) / 2);
            return dblTempResut;
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