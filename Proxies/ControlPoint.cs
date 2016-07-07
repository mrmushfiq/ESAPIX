﻿using ESAPIX.Interfaces;
using ESAPIX.Types;


namespace ESAPIX.Proxies
{
    public class ControlPoint : VMSProxy, IControlPoint
    {
        public double MetersetWeight { get; set; }

        public float[,] LeafPositions { get; set; }

        public VRect<double> JawPositions { get; set; }

        public double CollimatorAngle { get; set; }

        public double GantryAngle { get; set; }

        public double PatientSupportAngle { get; set; }
    }
}