﻿using System;

namespace Lab6
{
    public class Heater
    {
        public Heater(float temperature)
        {
            Temperature = temperature;
        }
        public float Temperature
        {
            get { return _Temperature; }
            set { _Temperature = value; }
        }
        private float _Temperature;
        public void OnTemperatureChanged(float newTemperature)
        {
            if (newTemperature < Temperature)
            {
                Console.WriteLine("Heater : On");
            }
            else
            {
                Console.WriteLine("Heater : Off");
            }
        }
    }
}