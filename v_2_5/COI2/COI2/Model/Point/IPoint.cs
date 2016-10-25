﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COI2.Model.Point
{
    public interface IPoint<T>
    {
        string GetType();
        string ValueToString();
    }

    public enum PointType
    {
        X,
        XY,
        XYZ
    }
}
