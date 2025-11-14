using System.Numerics;

namespace Jacobi.ArrayOperators;

public static class ArrayArithmetic
{
    extension<T>(T[]) where T : IAdditionOperators<T, T, T>
    {
        public static T[] operator +(T[] source, T[] other)
        {
            var len = Math.Min(source.Length, other.Length);
            T[] result = new T[len];
            for (int i = 0; i < len; i++)
                result[i] = source[i] + other[i];
            return result;
        }
    }
    extension<T>(T[]) where T : ISubtractionOperators<T, T, T>
    {
        public static T[] operator -(T[] source, T[] other)
        {
            var len = Math.Min(source.Length, other.Length);
            T[] result = new T[len];
            for (int i = 0; i < len; i++)
                result[i] = source[i] - other[i];
            return result;
        }
    }
    extension<T>(T[]) where T : IMultiplyOperators<T, T, T>
    {
        public static T[] operator *(T[] source, T[] other)
        {
            var len = Math.Min(source.Length, other.Length);
            T[] result = new T[len];
            for (int i = 0; i < len; i++)
                result[i] = source[i] * other[i];
            return result;
        }
    }
    extension<T>(T[]) where T : IDivisionOperators<T, T, T>
    {
        public static T[] operator /(T[] source, T[] other)
        {
            var len = Math.Min(source.Length, other.Length);
            T[] result = new T[len];
            for (int i = 0; i < len; i++)
                result[i] = source[i] / other[i];
            return result;
        }
    }
    extension<T>(T[]) where T : IModulusOperators<T, T, T>
    {
        public static T[] operator %(T[] source, T[] other)
        {
            var len = Math.Min(source.Length, other.Length);
            T[] result = new T[len];
            for (int i = 0; i < len; i++)
                result[i] = source[i] % other[i];
            return result;
        }
    }
}

public static class ArrayBitwiseArithmetic
{
    extension<T>(T[]) where T : IShiftOperators<T, int, T>
    {
        public static T[] operator <<(T[] source, int shiftAmount)
        {
            T[] result = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                result[i] = source[i] << shiftAmount;
            return result;
        }

        public static T[] operator >>(T[] source, int shiftAmount)
        {
            T[] result = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                result[i] = source[i] >> shiftAmount;
            return result;
        }

        public static T[] operator >>>(T[] source, int shiftAmount)
        {
            T[] result = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                result[i] = source[i] >>> shiftAmount;
            return result;
        }
    }

    extension<T>(T[]) where T : IBitwiseOperators<T, T, T>
    {
        public static T[] operator &(T[] left, T[] right)
        {
            var len = Math.Min(left.Length, right.Length);
            T[] result = new T[len];
            for (int i = 0; i < len; i++)
                result[i] = left[i] & right[i];
            return result;
        }
        public static T[] operator |(T[] left, T[] right)
        {
            var len = Math.Min(left.Length, right.Length);
            T[] result = new T[len];
            for (int i = 0; i < len; i++)
                result[i] = left[i] | right[i];
            return result;
        }
        public static T[] operator ^(T[] left, T[] right)
        {
            var len = Math.Min(left.Length, right.Length);
            T[] result = new T[len];
            for (int i = 0; i < len; i++)
                result[i] = left[i] ^ right[i];
            return result;
        }
        public static T[] operator ~(T[] source)
        {
            T[] result = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                result[i] = ~source[i];
            return result;
        }
    }
}

public static class ArrayInPlaceArithmetic
{
    extension<T>(T[] array) where T : IIncrementOperators<T>
    {
        public void operator ++()
        {
            for (int i = 0; i < array.Length; i++)
                array[i]++;
        }
    }
    extension<T>(T[] array) where T : IDecrementOperators<T>
    {
        public void operator --()
        {
            for (int i = 0; i < array.Length; i++)
                array[i]--;
        }
    }

    extension<T>(T[] array) where T : IAdditionOperators<T, T, T>
    {
        public void operator +=(T scalar)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] += scalar;
        }
    }
    extension<T>(T[] array) where T : ISubtractionOperators<T, T, T>
    {
        public void operator -=(T scalar)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] -= scalar;
        }
    }
    extension<T>(T[] array) where T : IMultiplyOperators<T, T, T>
    {
        public void operator *=(T scalar)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] *= scalar;
        }
    }
    extension<T>(T[] array) where T : IDivisionOperators<T, T, T>
    {
        public void operator /=(T scalar)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] /= scalar;
        }
    }
    extension<T>(T[] array) where T : IModulusOperators<T, T, T>
    {
        public void operator %=(T scalar)
        {
            for (int i = 0; i < array.Length; i++)
                array[i] %= scalar;
        }
    }
}

public static class ArrayScalarArithmetic
{
    extension<T>(T[]) where T : IAdditionOperators<T, T, T>
    {
        public static T[] operator +(T[] source, T scalar)
        {
            T[] result = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                result[i] = source[i] + scalar;
            return result;
        }
    }
    extension<T>(T[]) where T : ISubtractionOperators<T, T, T>
    {
        public static T[] operator -(T[] source, T scalar)
        {
            T[] result = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                result[i] = source[i] - scalar;
            return result;
        }
    }
    extension<T>(T[]) where T : IMultiplyOperators<T, T, T>
    {
        public static T[] operator *(T[] source, T scalar)
        {
            T[] result = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                result[i] = source[i] * scalar;
            return result;
        }
    }
    extension<T>(T[]) where T : IDivisionOperators<T, T, T>
    {
        public static T[] operator /(T[] source, T scalar)
        {
            T[] result = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                result[i] = source[i] / scalar;
            return result;
        }
    }
    extension<T>(T[]) where T : IModulusOperators<T, T, T>
    {
        public static T[] operator %(T[] source, T scalar)
        {
            T[] result = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                result[i] = source[i] % scalar;
            return result;
        }
    }
}

public static class ArrayMethods
{
    extension<T>(T[] source) where T : IFloatingPoint<T>
    {
        //public T[] Abs()
        //{
        //    var list = new T[source.Length];
        //    for (int i = 0; i < source.Length; i++)
        //        list[i] = T.Abs(source[i]);
        //    return list;
        //}

        public T[] Floor()
        {
            var list = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                list[i] = T.Floor(source[i]);
            return list;
        }

        public T[] Ceiling()
        {
            var list = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                list[i] = T.Ceiling(source[i]);
            return list;
        }

        public T[] Round()
        {
            var list = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                list[i] = T.Round(source[i]);
            return list;
        }
    }

    extension<T>(T[] source) where T : INumber<T>
    {
        public T[] Abs()
        {
            var list = new T[source.Length];
            for (int i = 0; i < source.Length; i++)
                list[i] = T.Abs(source[i]);
            return list;
        }
    }
}