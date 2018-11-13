using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectacleLensDesign
{
    class Prescription
    {
        Lens OptimisedLens;

        void CalculateOptimisedLens()
        {


        }

        double LensQuality(Lens LensToEvaluate)
        {
            LensToEvaluate.Power[1, 1] = 0.0; /* dummy code */
            return 0.0;
        }
    }
}
