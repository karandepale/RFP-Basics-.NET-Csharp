﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBasics
{
    public class ExpressionLambda
    {
        public static Func<int, int> sqr = x => x * x;
    }
}
