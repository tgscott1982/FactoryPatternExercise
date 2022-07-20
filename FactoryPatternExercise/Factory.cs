using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise;

public static class Factory
{
    public static IVehicle GetVehicle (int fuelType)
    {
        switch (fuelType)
        {
            case 1:
                return new Car();
            case 2:
                return new Electric();
            default:
                return new Car();

        }
    }
}
