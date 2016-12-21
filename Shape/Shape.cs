using System;

namespace ASI.ES.SkillUp.Shape
{
    /// <summary>
    /// Base Class：Shape (Abstract Class)
    /// Necessary functions
    /// ・Area calculation（Abstract function）
    /// ・Perimeter calculation（Abstract function）
    /// ・Attach serial numbers to the object
    /// ・Property to get serial number
    /// ・Function to display the class name（Virtual）（for debugging)
    /// </summary>
    abstract class Shape
    {
        #region Member Variable
        private static int m_nSerialNumber;
        #endregion

        #region Properties
        /// <summary>
        /// Get and set property for serial number.
        /// </summary>
        public int SerialNumber { get; private set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor used to assign a number of object count to SerialNumber property.
        /// </summary>
        public Shape()
        {
            SerialNumber = ++m_nSerialNumber;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Abstract method declaration for calculate area.
        /// </summary>
        /// <returns>Calculated area, return double Type</returns>
        public abstract double CalculateArea();

        /// <summary>
        /// Abstract method declaration for calculate perimeter.
        /// </summary>
        /// <returns>Calculated perimeter, return double Type</returns>
        public abstract double CalculatePerimeter();

        /// <summary>
        /// Display class name
        /// </summary>
        public virtual void DisplayClassName()
        {
            //Display class name
            Console.WriteLine(this.GetType().Name);
        }
        #endregion
    }
}