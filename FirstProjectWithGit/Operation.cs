﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FirstProjectWithGit
{
    class Operation
    {
        public double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Del(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Umn(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
