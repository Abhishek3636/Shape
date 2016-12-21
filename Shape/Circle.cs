using System;

namespace ASI.ES.SkillUp.Shape
{
    /// <summary>
    /// Derived class：Circle(Base is Oval)
    /// Necessary functions
    /// ・Area calculation（Parameterised function）
    /// ・Function to display the class name (override)（for debugging）
    /// </summary>
    class Circle : Oval
    {
        #region Properties
        /// <summary>
        /// For set and get value for radius of circle.
        /// </summary>
        public double Radius
        {
            set
            {
                base.MajorAxis = value;
                base.MinorAxis = value;
            }
            get
            {
                return MajorAxis;
            }
        }

        public new double MajorAxis
        {
            get
            {
                return Radius;
            }
        }

        public new double MinorAxis
        {
            get
            {
                return Radius;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public Circle() { }

        /// <summary>
        /// Parameterize constructor for initialize Radius property.
        /// </summary>
        /// <param name="dblRadius">Double type, to set radius</param>
        public Circle(double dblRadius)
        {
            Radius = dblRadius;
        }
        #endregion

        #region Method
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