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
                result.Add(source[i] + other[i]);
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
                result.Add(source[i] - other[i]);
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
                result.Add(source[i] * other[i]);
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
                result.Add(source[i] / other[i]);
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
                result.Add(source[i] % other[i]);
            return result;
        }
    }
}

public static class ListBitwiseArithmetic
{
    extension<T>(IList<T>) where T : IShiftOperators<T, int, T>
    {
        public static IList<T> operator <<(IList<T> source, int shiftAmount)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                list.Add(source[i] << shiftAmount);
            return list;
        }

        public static IList<T> operator >>(IList<T> source, int shiftAmount)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                list.Add(source[i] >> shiftAmount);
            return list;
        }

        public static IList<T> operator >>>(IList<T> source, int shiftAmount)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                list.Add(source[i] >>> shiftAmount);
            return list;
        }
    }

    extension<T>(IList<T>) where T : IBitwiseOperators<T, T, T>
    {
        public static IList<T> operator &(IList<T> left, IList<T> right)
        {
            var len = Math.Min(left.Count, right.Count);
            IList<T> result = new List<T>(len);
            for (int i = 0; i < len; i++)
                result.Add(left[i] & right[i]);
            return result;
        }
        public static IList<T> operator |(IList<T> left, IList<T> right)
        {
            var len = Math.Min(left.Count, right.Count);
            IList<T> result = new List<T>(len);
            for (int i = 0; i < len; i++)
                result.Add(left[i] | right[i]);
            return result;
        }
        public static IList<T> operator ^(IList<T> left, IList<T> right)
        {
            var len = Math.Min(left.Count, right.Count);
            IList<T> result = new List<T>(len);
            for (int i = 0; i < len; i++)
                result.Add(left[i] ^ right[i]);
            return result;
        }
        public static IList<T> operator ~(IList<T> source)
        {
            IList<T> result = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                result.Add(~source[i]);
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
            for (int i = 0; i < source.Count; i++)
                list.Add(source[i] + scalar);
            return list;
        }
    }
    extension<T>(IList<T>) where T : ISubtractionOperators<T, T, T>
    {
        public static IList<T> operator -(IList<T> source, T scalar)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                list.Add(source[i] - scalar);
            return list;
        }
    }
    extension<T>(IList<T>) where T : IMultiplyOperators<T, T, T>
    {
        public static IList<T> operator *(IList<T> source, T scalar)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                list.Add(source[i] * scalar);
            return list;
        }
    }
    extension<T>(IList<T>) where T : IDivisionOperators<T, T, T>
    {
        public static IList<T> operator /(IList<T> source, T scalar)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                list.Add(source[i] / scalar);
            return list;
        }
    }
    extension<T>(IList<T>) where T : IModulusOperators<T, T, T>
    {
        public static IList<T> operator %(IList<T> source, T scalar)
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                list.Add(source[i] % scalar);
            return list;
        }
    }
}

public static class ListMethods
{
    extension<T>(IList<T> source) where T : IFloatingPoint<T>
    {
        //public IList<T> Abs()
        //{
        //    var list = new List<T>(source.Count);
        //    for (int i = 0; i < source.Count; i++)
        //        list.Add(T.Abs(source[i]));
        //    return list;
        //}

        public IList<T> Floor()
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                list.Add(T.Floor(source[i]));
            return list;
        }

        public IList<T> Ceiling()
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                list.Add(T.Ceiling(source[i]));
            return list;
        }

        public IList<T> Round()
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                list.Add(T.Round(source[i]));
            return list;
        }
    }

    extension<T>(IList<T> source) where T : INumber<T>
    {
        public IList<T> Abs()
        {
            var list = new List<T>(source.Count);
            for (int i = 0; i < source.Count; i++)
                list.Add(T.Abs(source[i]));
            return list;
        }
    }
}