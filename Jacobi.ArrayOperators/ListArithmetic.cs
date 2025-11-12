using System.Numerics;

namespace Jacobi.ArrayOperators;

public static class ListArithmetic
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
