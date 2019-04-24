/*
 * 
 * Created by Peter Gorman
 * ClosestPoints.cs
 * 
 */

using PeterRG.DataTypes;
using PeterRG.RandomUtilities;
using PeterRG.Sorting;
using System.Diagnostics;

namespace PeterRG.Projects
{
    class ClosestPoints
    {
        public static async void Run()
        {
            Vector2[] vectors = RandomArray.Vector2(10);
            double[] distances = new double[10];
            double closestDistance = double.MaxValue;

            for (int i=0; i<10; i++)
            {
                distances[i] = Vector2.Distance(Vector2.Zero(), vectors[i]);
                Debug.WriteLine($"{vectors[i].ToString()} has a distance of {distances[i]}");
            }

            distances = Bubble.Sort(distances);

            Debug.WriteLine($"The closest distance is {closestDistance}");
        }
    }
}