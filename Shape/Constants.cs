using System;

namespace ASI.ES.SkillUp.Shape
{
    /// <summary>
    /// Constants class.
    /// </summary>
    class Constants
    {
        //Store a program definition message
        public const string ProgramName           = "Shape Program";
        public const string ProgramDescription    = "Calculate area and perimeter of rectangle, oval and circle";

        //Store class heading messages
        public const string RectangleName         = "Rectangle Demo.\n";
        public const string OvalName              = "Oval Demo.\n";
        public const string CircleName            = "Circle Demo.\n";

        //For console formatting
        public const string Separator              = "------------------------------------------------------------------------------";
     }

     /// <summary>
     /// Error class.
     /// </summary>
     class Errors
     {
         //Store a exception message
         public const string Tag                           = "ERROR : ";
         public const string InvalidInput                  = "Invalid Input.";
         public const string MinorAxisGreaterThanMajorAxis = "Minor axis is grater than Major axis.";
         public const string MinorOrMajorAxisZero          = "Minor axis or Major axis is zero.";
         public const string HightOrWidthZero              = "Height or Width is zero.";
         public const string RadiusZero                    = "Radius is zero.";
     }

     /// <summary>
     /// Messages class.
     /// </summary>
     class Messgages
     {
         //For user input related messages
         public const string EnterTop        = "Enter Top    : ";
         public const string EnterBottom     = "Enter Bottom : ";
         public const string EnterLeft       = "Enter Left   : ";
         public const string EnterRight      = "Enter Right  : ";
         public const string EnterMinorAxis  = "Enter Minor axis : ";
         public const string EntorMajorAxis  = "Enter Major axis : ";
         public const string EnterRadius     = "Enter Radius : ";

         //For display result related messages
         public const string AreaTag         = "Area          : ";
         public const string PerimeterTag    = "Perimeter     : ";
         public const string ClassNameTag    = "Class Name    : ";
         public const string SerialNumberTag = "\nSerial Number : ";
     }
}