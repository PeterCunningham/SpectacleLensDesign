using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpectacleLensDesign
{
    class Lens
    {
        private int n_i, n_j;
        double[,] Front_z;
        double[,] Rear_z;
        public double[,] Power;
        double RefractiveIndex;
        
        void SetCartesianArraysSize(int Num_I, int Num_J)
        {
            n_i = Num_I;
            n_j = Num_J;

            Front_z = new double[n_i, n_j];
            Rear_z = new double[n_i, n_j];
            Power = new double[n_i, n_j];
        }
        void CalculatePower() { }


    }


}
