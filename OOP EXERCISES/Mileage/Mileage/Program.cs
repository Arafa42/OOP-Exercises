using System;
using System.Collections.Generic;

namespace Mileage
{
    class Program
    {
        static void Main(string[] args)
        {

            //FIND OTHER SOLUTION ASTEMBLIEFT DEZE OPLOSSING IS KAK
            GasMileage waggie = new GasMileage();
            List<float> waggieMiles = new List<float>();
            List<float> waggieGallons = new List<float>();
            waggieMiles.Add(10f);
            waggieMiles.Add(20f);
            waggieGallons.Add(5f);
            waggieGallons.Add(1.4f);
            waggie.CalculateMileage(waggieMiles, waggieGallons);

        }
    }
}
