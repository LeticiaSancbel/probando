﻿using System;

namespace Leticia
{
    public class Class_operator
    {
        public int result(string value)
        {
            int counter = 0;

            if (value.Contains ("&&"))
            {
                counter++;
            }
            if (value.Contains("||"))
            {
                counter++;
            }
            if (value.Contains("!"))
            {
                counter++;
            }
            return counter;
        }
    }
}
