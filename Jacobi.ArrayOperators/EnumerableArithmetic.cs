using System.Numerics;

namespace Jacobi.ArrayOperators;

public static class EnumerableArithmetic
{
    extension<T>(T) where T : IAdditionOperators<T, T, T>
    {
        public static IEnumerable<T> operator +(IEnumerable<T> source, T scalar)
        {
            var list = new List<T>(source);
            for (int i = 0; i < list.Count; i++)
                list[i] += scalar;
            return list;
        }
    }
    extension<T>(T) where T : ISubtractionOperators<T, T, T>
    {
        public static IEnumerable<T> operator -(IEnumerable<T> source, T scalar)
        {
            var list = new List<T>(source);
            for (int i = 0; i < list.Count; i++)
                list[i] -= scalar;
            return list;
        }
    }
    extension<T>(T) where T : IMultiplyOperators<T, T, T>
    {
        public static IEnumerable<T> operator *(IEnumerable<T> source, T scalar)
        {
            var list = new List<T>(source);
            for (int i = 0; i < list.Count; i++)
                list[i] *= scalar;
            return list;
        }
    }
    extension<T>(T) where T : IDivisionOperators<T, T, T>
    {
        public static IEnumerable<T> operator /(IEnumerable<T> source, T scalar)
        {
            var list = new List<T>(source);
            for (int i = 0; i < list.Count; i++)
                list[i] /= scalar;
            return list;
        }
    }
    extension<T>(T) where T : IModulusOperators<T, T, T>
    {
        public static IEnumerable<T> operator %(IEnumerable<T> source, T scalar)
        {
            var list = new List<T>(source);
            for (int i = 0; i < list.Count; i++)
                list[i] %= scalar;
            return list;
        }
    }
}
