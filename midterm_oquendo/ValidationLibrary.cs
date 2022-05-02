﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm_oquendo
{
    class ValidationLibrary
    {

        public static bool GotPoop(string temp)
        {
            bool result = false;

            if (temp.Contains("Poop"))
            {
                result = true;
            }

            return result;
        }

        public static bool IsItFilledZip(string temp)
        {
            bool result = false;

            if (temp.Length == 5)
            {
                result = true;
            }

            return result;
        }

        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }

        public static bool IsItFilledPhone(string temp)
        {
            bool result = false;

            if (temp.Length == 10)
            {
                result = true;
            }
            
            return result;
        }

        public static bool stateABV(string temp, int maxlen)
        {
            bool result = false;
            maxlen = 2;

            if (temp.Length == maxlen)
            {
                result = true;
            }
            
            return result;
        }

        public static bool IsValidEmail(string temp)
        {
            bool blnResult = true;

            //look for position of "@"
            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);

            //temp = email@aol.com
            //length = 13
            //position of last period = 10

            //look for last period
            int periodLocation = temp.LastIndexOf(".");

            //check min length
            if (temp.Length < 8)
            {
                blnResult = false;
            }
            else if (atLocation < 2) //if -1, not found and needs at least 2 chars in front
            {
                blnResult = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                blnResult = false;
            }

            return blnResult;

        }

        public static bool IsMinAmount(int temp, int min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;

        }

        public static bool IsMinAmount(double temp, double min)
        {
            bool blnResult;

            if (temp >= min)
            {
                blnResult = true;
            }
            else
            {
                blnResult = false;
            }

            return blnResult;

        }

    }
}