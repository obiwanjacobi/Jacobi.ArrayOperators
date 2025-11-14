using System.Numerics;

namespace Jacobi.ArrayOperators;

public static class FloatingPointMethods
{
    extension<T>(IEnumerable<T> source) where T : IFloatingPoint<T>
    {
        //public IEnumerable<T> Abs()
        //{
        //    foreach (var item in source)
        //        yield return T.Abs(item);
        //}

        public IEnumerable<T> Floor()
        {
            foreach (var item in source)
                yield return T.Floor(item);
        }

        public IEnumerable<T> Ceiling()
        {
            foreach (var item in source)
                yield return T.Ceiling(item);
        }

        public IEnumerable<T> Round()
        {
            foreach (var item in source)
                yield return T.Round(item);
        }
    }
}

public static class NumberMethods
{
    extension<T>(IEnumerable<T> source) where T : INumber<T>
    {
        public T Sum()
        {
            T sum = T.Zero;
            foreach (var item in source)
                sum += item;
            return sum;
        }

        public T Product()
        {
            T product = T.One;
            foreach (var item in source)
                product *= item;
            return product;
        }

        public T Average()
        {
            T sum = T.Zero;
            int count = 0;
            foreach (var item in source)
            {
                sum += item;
                count++;
            }
            return count > 0 ? sum / T.CreateChecked(count) : T.Zero;
        }

        public IEnumerable<T> Abs()
        {
            foreach (var item in source)
                yield return T.Abs(item);
        }
    }
}
