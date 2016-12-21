using System;
using System.IO;
using ASI.ES.SkillUp.Utililty;

namespace ASI.ES.SkillUp.Shape
{
    /// <summary>
    /// Create a shape class and derive rectangle and oval classes from it.
    /// Further derive a circle class making oval class as its base class.
    /// Create the below given classes and write a good test program to test all the classes.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Beginning of main function
        /// </summary>
        /// <param name="args">Hold command line argument</param>
        static void Main(string[] args)
        {


            #region variables and object
            //Store a result of area and perimeter
            double dblArea = 0.0;
            double dblPerimeter = 0.0;

            //For check validation
            bool bSuccess;

            //Create a Shape class object
            Shape objShape;
            #endregion

            #region Show Program Header
            //For display program header.
            Console.Clear();
            Console.WriteLine(Constants.Separator);
            Console.WriteLine(Constants.ProgramName);
            Console.WriteLine(Constants.Separator);
            Console.WriteLine(Constants.ProgramDescription);
            Console.WriteLine(Constants.Separator);
            Console.WriteLine(Constants.Separator);
            #endregion

            #region Rectangle
            //========================================== Rectangle =========================================
            Console.WriteLine(Constants.RectangleName);
            do
            {
                //Read user input and validate of top, bottom, left and right of rectangle,
                //with the use of calling ReadValidDouble Method
                double dblTopUserInput;
                IOUtility.ReadValidDouble(Messgages.EnterTop, out dblTopUserInput);

                double dblLeftUserInput;
                IOUtility.ReadValidDouble(Messgages.EnterLeft, out dblLeftUserInput);

                double dblBottomUserInput;
                IOUtility.ReadValidDouble(Messgages.EnterBottom, out dblBottomUserInput);

                double dblRightUserInput;
                IOUtility.ReadValidDouble(Messgages.EnterRight, out dblRightUserInput);

                //Check validation for height and width is zero or not.
                if (Math.Abs(dblTopUserInput - dblBottomUserInput) == 0 || 
                    Math.Abs(dblLeftUserInput - dblRightUserInput) == 0)
                {
                    Console.WriteLine(Errors.Tag + Errors.HightOrWidthZero);
                    bSuccess = false;
                }
                else
                {
                    //Create a object of rectangle and set properties of left,right,top and bottom.
                    Rectangle objRectangle = new Rectangle();
                    objRectangle.Top = dblTopUserInput;
                    objRectangle.Bottom = dblBottomUserInput;
                    objRectangle.Left = dblLeftUserInput;
                    objRectangle.Right = dblRightUserInput;

                    //Assign objRectangle object to objShape object
                    objShape = objRectangle;

                    //Call a CalculateArea method for calculate area of rectangle
                    dblArea = objRectangle.CalculateArea();
                    dblArea = Math.Round(dblArea, 2);

                    //Call a CalculatePerimeter method for calculate perimeter of rectangle
                    dblPerimeter = objRectangle.CalculatePerimeter();
                    dblPerimeter = Math.Round(dblPerimeter, 2);

                    #region Results messages
                    //Display serial number, class name, area and perimeter of rectangle.
                    Console.WriteLine(Messgages.SerialNumberTag + objShape.SerialNumber);
                    Console.Write(Messgages.ClassNameTag);
                    objRectangle.DisplayClassName();
                    Console.WriteLine(Messgages.AreaTag + dblArea);
                    Console.WriteLine(Messgages.PerimeterTag + dblPerimeter);
                    Console.WriteLine(Constants.Separator);
                    #endregion

                    //Store true in bSuccess for successful completion.
                    bSuccess = true;
                }
            } while (bSuccess == false);
            #endregion

            #region Oval
            //========================================== Oval =========================================
            Console.WriteLine(Constants.OvalName);
            do
            {
                //Read user input and validate of major axis and minor axis of oval,
                //with the use of calling ReadValidDoubleMethod
                double dblMajorAxisUserInput = 0.0;
                IOUtility.ReadValidDouble(Messgages.EntorMajorAxis, out dblMajorAxisUserInput);

                double dblMinorAxisUserInput = 0.0;
                IOUtility.ReadValidDouble(Messgages.EnterMinorAxis, out dblMinorAxisUserInput);

                //Check validation for major axis and minor axis is zero or not.
                if (dblMajorAxisUserInput == 0 || dblMinorAxisUserInput == 0)
                {
                    Console.WriteLine(Errors.Tag + Errors.MinorOrMajorAxisZero);
                    bSuccess = false;
                }
                //Check validation for major axis is greater or not.
                else if (dblMajorAxisUserInput < dblMinorAxisUserInput)
                {
                    Console.WriteLine(Errors.Tag + Errors.MinorAxisGreaterThanMajorAxis);
                    bSuccess = false;
                }
                else
                {
                    //Create a object of oval and set a major axis and minor axis property
                    Oval objOval = new Oval();
                    objOval.MajorAxis = dblMajorAxisUserInput;
                    objOval.MinorAxis = dblMinorAxisUserInput;

                    //Assign objOval object to objShape object
                    objShape = objOval;

                    //Call a CalculateArea method for calculate area of oval
                    dblArea = objShape.CalculateArea();
                    dblArea = Math.Round(dblArea, 2);

                    //Call a CalculatePerimeter method for calculate perimeter of oval
                    dblPerimeter = objShape.CalculatePerimeter();
                    dblPerimeter = Math.Round(dblPerimeter, 2);

                    #region Results messages
                    //Display serial number, class name, area and perimeter of oval
                    Console.WriteLine(Messgages.SerialNumberTag + objShape.SerialNumber);
                    Console.Write(Messgages.ClassNameTag);
                    objShape.DisplayClassName();
                    Console.WriteLine(Messgages.AreaTag + dblArea);
                    Console.WriteLine(Messgages.PerimeterTag + dblPerimeter);
                    Console.WriteLine(Constants.Separator);
                    #endregion

                    bSuccess = true;
                }
            } while (bSuccess == false);
            #endregion

            #region Circle
            //========================================== Circle =========================================
            Console.WriteLine(Constants.CircleName);
            do
            {
                //Read user input and validate of radius of circle,
                //with the use of calling ReadValidDoubleMethod
                double dblRadiusUserInput = 0.0;
                IOUtility.ReadValidDouble(Messgages.EnterRadius, out dblRadiusUserInput);

                //Check validation for radius is zero or not.
                if (dblRadiusUserInput == 0)
                {
                    Console.WriteLine(Errors.Tag + Errors.RadiusZero);
                    bSuccess = false;
                }
                else
                {
                    //Create a object of circle and set a radius property
                    Circle objCircle = new Circle();
                    objCircle.Radius = dblRadiusUserInput;

                    //Assign objCircle object to objShape object
                    objShape = objCircle;

                    //Call a CalculateArea method for calculate area of circle
                    dblArea = objShape.CalculateArea();
                    dblArea = Math.Round(dblArea, 2);

                    //Call a CalculatePerimeter method for calculate perimeter of circle
                    dblPerimeter = objShape.CalculatePerimeter();
                    dblPerimeter = Math.Round(dblPerimeter, 2);

                    #region Results messages
                    //Display serial number, class name, area and perimeter of circle
                    Console.WriteLine(Messgages.SerialNumberTag + objShape.SerialNumber);
                    Console.Write(Messgages.ClassNameTag);
                    objShape.DisplayClassName();
                    Console.WriteLine(Messgages.AreaTag + dblArea);
                    Console.WriteLine(Messgages.PerimeterTag + dblPerimeter);
                    #endregion

                    bSuccess = true;
                }
            } while (bSuccess == false);
            #endregion
        }
    }
}