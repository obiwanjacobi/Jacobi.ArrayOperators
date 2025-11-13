using System.Numerics;

namespace Jacobi.ArrayOperators;

public static class ListArithmetic
{
    extension<T>(IList<T>) where T : IAdditionOperators<T, T, T>
    {
        public static IList<T> operator +(IList<T> source, IList<T> other)
        {
            var len = Math.Min(source.Count, other.Count);
            IList<T> result = new List<T>(len);
            for (int i = 0; i < len; i++)
                result[i] = source[i] + other[i];
            return result;
        }
    }
    extension<T>(IList<T>) where T : ISubtractionOperators<T, T, T>
    {
        public static IList<T> operator -(IList<T> source, IList<T> other)
        {
            var len = Math.Min(source.Count, other.Count);
            IList<T> result = new List<T>(len);
            for (int i = 0; i < len; i++)
                result[i] = source[i] - other[i];
            return result;
        }
    }
    extension<T>(IList<T>) where T : IMultiplyOperators<T, T, T>
    {
        public static IList<T> operator *(IList<T> source, IList<T> other)
        {
            var len = Math.Min(source.Count, other.Count);
            IList<T> result = new List<T>(len);
            for (int i = 0; i < len; i++)
                result[i] = source[i] * other[i];
            return result;
        }
    }
    extension<T>(IList<T>) where T : IDivisionOperators<T, T, T>
    {
        public static IList<T> operator /(IList<T> source, IList<T> other)
        {
            var len = Math.Min(source.Count, other.Count);
            IList<T> result = new List<T>(len);
            for (int i = 0; i < len; i++)
                result[i] = source[i] / other[i];
            return result;
        }
    }
    extension<T>(IList<T>) where T : IModulusOperators<T, T, T>
    {
        public static IList<T> operator %(IList<T> source, IList<T> other)
        {
            var len = Math.Min(source.Count, other.Count);
            IList<T> result = new List<T>(len);
            for (int i = 0; i < len; i++)
                result[i] = source[i] % other[i];
            return result;
        }
    }
}

public static class ListInPlaceArithmetic
{
    extension<T>(IList<T> list) where T : IIncrementOperators<T>
    {
        public void operator ++()
        {
            for (int i = 0; i < list.Count; i++)
                list[i]++;
        }
    }

    extension<T>(IList<T> list) where T : IDecrementOperators<T>
    {
        public void operator --()
        {
            for (int i = 0; i < list.Count; i++)
                list[i]--;
        }
    }

    extension<T>(IList<T> list) where T : IAdditionOperators<T, T, T>
    {
        public void operator +=(T scalar)
        {
            for (int i = 0; i < list.Count; i++)
                list[i] += scalar;
        }
    }

    extension<T>(IList<T> list) where T : ISubtractionOperators<T, T, T>
    {
        public void operator -=(T scalar)
        {
            for (int i = 0; i < list.Count; i++)
                list[i] -= scalar;
        }
    }

    extension<T>(IList<T> list) where T : IMultiplyOperators<T, T, T>
    {
        public void operator *=(T scalar)
        {
            for (int i = 0; i < list.Count; i++)
                list[i] *= scalar;
        }
    }

    extension<T>(IList<T> list) where T : IDivisionOperators<T, T, T>
    {
        public void operator /=(T scalar)
        {
            for (int i = 0; i < list.Count; i++)
                list[i] /= scalar;
        }
    }

    extension<T>(IList<T> list) where T : IModulusOperators<T, T, T>
    {
        public void operator %=(T scalar)
        {
            for (int i = 0; i < list.Count; i++)
                list[i] %= scalar;
        }
    }
}

public static class ListScalarArithmetic
{
    extension<T>(IList<T>) where T : IAdditionOperators<T, T, T>
    {
        public static IList<T> operator +(IList<T> source, T scalar)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < list.Count; i++)
                list[i] = source[i] + scalar;
            return list;
        }
    }
    extension<T>(IList<T>) where T : ISubtractionOperators<T, T, T>
    {
        public static IList<T> operator -(IList<T> source, T scalar)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < list.Count; i++)
                list[i] = source[i] - scalar;
            return list;
        }
    }
    extension<T>(IList<T>) where T : IMultiplyOperators<T, T, T>
    {
        public static IList<T> operator *(IList<T> source, T scalar)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < list.Count; i++)
                list[i] = source[i] * scalar;
            return list;
        }
    }
    extension<T>(IList<T>) where T : IDivisionOperators<T, T, T>
    {
        public static IList<T> operator /(IList<T> source, T scalar)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < list.Count; i++)
                list[i] = source[i] / scalar;
            return list;
        }
    }
    extension<T>(IList<T>) where T : IModulusOperators<T, T, T>
    {
        public static IList<T> operator %(IList<T> source, T scalar)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < list.Count; i++)
                list[i] = source[i] % scalar;
            return list;
        }
    }
}