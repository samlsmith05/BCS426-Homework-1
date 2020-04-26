//******************************************************
// File: Category.cs
//
// Purpose: Contains the class definition for Category.
//          
//
// Written By: Samantha Smith 
//
// Compiler: Visual Studio 2019
//
//******************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCS426Homework1DLL
{
    //****************************************************
    // Class: Category{}
    //
    // Purpose: contains the properties and methods for the Category class
    //          which will be used in the Unit Testing Class
    //
    // Update Information
    // ------------------
    // 
    //
    //****************************************************
    public class Category
    {
        #region Member Variables
        //Member variables
        private string name;
        private double percentage;

        #endregion

        #region Category Properties
        //properties for member variable name
        public string Name
        { 
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //properties for member variable percentage
        public double Percentage
        {
            get
            {
                return percentage;
            }
            set
            {
                percentage = value;
            }
        }

        #endregion

        #region Category Methods/Constructors
        //****************************************************
        // Method: Category()
        //
        // Purpose: default constructor for Category
        //
        //****************************************************

        public Category()
        {
            name = "No name";
            percentage = 0.0;
        }


        //****************************************************
        // Method: ToString()
        //
        // Purpose: To show descriptive text and data for all member 
        //          variables by overriding ToString
        //****************************************************

        public override string ToString()
        {
            return name + " , " + percentage;
        }

        #endregion
    }


}
