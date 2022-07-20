﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise;

internal class Electric : IVehicle
{
    public Electric()
    {

    }
    public void Drive()
    {
        Console.WriteLine("Building a new electric car!");
    }
}
