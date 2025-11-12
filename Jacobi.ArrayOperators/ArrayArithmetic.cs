using System.Numerics;

namespace Jacobi.ArrayOperators;

public static class ArrayArithmetic
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
