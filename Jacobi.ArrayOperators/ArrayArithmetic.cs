using System.Numerics;

namespace Jacobi.ArrayOperators;

public static class ArrayArithmetic
{
    // handled by EnumerableExtensions
    //extension<T>(T) where T : IAdditionOperators<T, T, T>
    //{
    //    public static T[] operator +(T[] array, T scalar)
    //    {
    //        var arr = (T[])array.Clone();
    //        for (int i = 0; i < arr.Length; i++)
    //            arr[i] += scalar;
    //        return arr;
    //    }
    //}
    //extension<T>(T) where T : ISubtractionOperators<T, T, T>
    //{
    //    public static T[] operator -(T[] array, T scalar)
    //    {
    //        var arr = (T[])array.Clone();
    //        for (int i = 0; i < arr.Length; i++)
    //            arr[i] -= scalar;
    //        return arr;
    //    }
    //}
    //extension<T>(T) where T : IMultiplyOperators<T, T, T>
    //{
    //    public static T[] operator *(T[] array, T scalar)
    //    {
    //        var arr = (T[])array.Clone();
    //        for (int i = 0; i < arr.Length; i++)
    //            arr[i] *= scalar;
    //        return arr;
    //    }
    //}
    //extension<T>(T) where T : IDivisionOperators<T, T, T>
    //{
    //    public static T[] operator /(T[] array, T scalar)
    //    {
    //        var arr = (T[])array.Clone();
    //        for (int i = 0; i < arr.Length; i++)
    //            arr[i] /= scalar;
    //        return arr;
    //    }
    //}
    //extension<T>(T) where T : IModulusOperators<T, T, T>
    //{
    //    public static T[] operator %(T[] array, T scalar)
    //    {
    //        var arr = (T[])array.Clone();
    //        for (int i = 0; i < arr.Length; i++)
    //            arr[i] %= scalar;
    //        return arr;
    //    }
    //}

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
