using System;
using System.Device.Location;
using Exercises.Models;

namespace Exercises
{
    static class PropertyExtentions
    {
        public static double DistanceTo(this Property sourceProperty, Property destinationProperty)
        {
            GeoCoordinate sourceCoordinate = new GeoCoordinate(Convert.ToDouble(sourceProperty.Latitude), Convert.ToDouble(sourceProperty.Longitude));
            GeoCoordinate destinationCoordinate = new GeoCoordinate(Convert.ToDouble(destinationProperty.Latitude), Convert.ToDouble(destinationProperty.Longitude));

            return sourceCoordinate.GetDistanceTo(destinationCoordinate);
        }
    }
}
