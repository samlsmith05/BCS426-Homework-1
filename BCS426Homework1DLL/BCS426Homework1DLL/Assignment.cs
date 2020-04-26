//******************************************************
// File: Assignment.cs
//
// Purpose: Contains the class definition for Assignment
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
    // Class: Assignment{}
    //
    // Purpose: contains the properties and methods for the Assignment class
    //          which will be used in the Unit Testing Class
    //
    // Update Information
    // ------------------
    // 
    //
    //****************************************************
    class Assignment
    {
        #region Member Variables
        //Member variables
        private string name;
        private string description;
        private string categoryName;

        #endregion

        #region Assignment Properties
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

        //properties for member variable description
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        //properties for member variable categoryName
        public string CategoryName
        {
            get
            {
                return categoryName;
            }
            set
            {
                categoryName = value;
            }
        }

        #endregion

        #region Assignment Methods/Constructors
        //****************************************************
        // Method: Assignment()
        //
        // Purpose: default constructor for Assignment
        //
        //****************************************************

        public Assignment()
        {
            name = "No name";
            description = "No description";
            categoryName = "No category";
        }


        //****************************************************
        // Method: ToString()
        //
        // Purpose: To show descriptive text and data for all member 
        //          variables by overriding ToString
        //****************************************************

        public override string ToString()
        {
            return name + " , " + description + " , " + categoryName;
        }

        #endregion
    }
}
