using System;
using System.Collections.Generic;
using System.Text;

namespace Mileage
{
    class GasMileage
    {
        public GasMileage() { }

        public void CalculateMileage(List<float> miles, List<float> gallons)
        {

            float totalMiles = 0.0f;
            float totalGallons = 0.0f;

            for (int i = 0; i < miles.Count; i++)
            {
               totalMiles += miles[i];
               totalGallons += gallons[i];

            }





            Console.WriteLine($"TOTAL MILES REGISTERED : {totalMiles}");
            Console.WriteLine($"TOTAL GALLONS REGISTERED : {totalGallons}");
            Console.WriteLine($"TOTAL AVERAGE MILES PER GALLON : {totalMiles/totalGallons}");
        }





    }
}
