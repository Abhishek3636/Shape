using System;
using System.IO;
using ASI.ES.SkillUp.Shape;

namespace ASI.ES.SkillUp.Utililty
{
    /// <summary>
    /// IOUtility class is used for read user input and check validation.
    /// </summary>
    class IOUtility
    {
        #region Method
        /// <summary>
        /// To get double type input as well as validation of input from the user 
        /// </summary>
        /// <param name="sInputMessage">String type, For display input related message</param>
        /// <param name="dblArgument">Double type, Input value store in nArgument</param>
        public static void ReadValidDouble(string sInputMessage, out double dblArgument)
        {
            try
            {
                bool bResult = true;
                do
                {
                    //Display input related message and get input.
                    Console.Write(sInputMessage);
                    String sInput = Console.ReadLine();

                    //check an input validation for double type.
                    bResult = double.TryParse(sInput, out dblArgument);
                    if (bResult)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(Errors.Tag + Errors.InvalidInput);
                    }
                } while (bResult == false);
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }
        #endregion
    }
}