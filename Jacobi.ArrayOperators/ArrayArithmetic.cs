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