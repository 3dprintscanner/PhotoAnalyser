using System;
using MathNet.Numerics.LinearAlgebra.Complex32;

namespace PhotoAnalyser
{
    public interface IGeometryResolver
    {
        /// <summary>
        /// Gets the index of the pixel for a given latlong in the resolvers matrix
        /// </summary>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <returns></returns>
        Tuple<int, int> GetPixelIndex(decimal lat, decimal lng);

        /// <summary>
        /// Finds the applicable pixel set between the control points for further analysis
        /// </summary>
        /// <param name="bottomLeft"></param>
        /// <param name="topRight"></param>
        /// <returns></returns>
        Matrix GetIntermediaryPixelSet(Tuple<decimal, decimal> bottomLeft, Tuple<decimal, decimal> topRight);

    }
}