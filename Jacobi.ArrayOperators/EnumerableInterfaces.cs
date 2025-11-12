using System.Numerics;

namespace Jacobi.ArrayOperators;

public static class EnumerableInterfaces
{
    extension<T>(IEnumerable<T> source) where T : IEquatable<T>
    {
        public bool Equals(IEnumerable<T> other)
            => source.SequenceEqual(other);
        public static bool operator ==(IEnumerable<T> first, IEnumerable<T> other)
            => first.Equals(other);
        public static bool operator !=(IEnumerable<T> first, IEnumerable<T> other)
            => !first.Equals(other);
    }

    extension<T>(IEnumerable<T> source) where T : IComparable<T>
    {
        public int CompareTo(IEnumerable<T> other)
        {
            using var enum1 = source.GetEnumerator();
            using var enum2 = other.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 && !has2)
                    return 0; // equal length and all elements equal
                if (!has1)
                    return -1; // first is shorter
                if (!has2)
                    return 1; // second is shorter
                var cmp = enum1.Current.CompareTo(enum2.Current);
                if (cmp != 0)
                    return cmp; // elements differ
            }
        }
        public static bool operator >(IEnumerable<T> first, IEnumerable<T> other)
            => first.CompareTo(other) > 0;
        public static bool operator <(IEnumerable<T> first, IEnumerable<T> other)
            => first.CompareTo(other) < 0;
        public static bool operator >=(IEnumerable<T> first, IEnumerable<T> other)
            => first.CompareTo(other) >= 0;
        public static bool operator <=(IEnumerable<T> first, IEnumerable<T> other)
            => first.CompareTo(other) <= 0;
    }

    extension<T>(IEnumerable<T> source) where T : IFloatingPoint<T>
    {
        public IEnumerable<T> Abs()
        {
            foreach (var item in source)
                yield return T.Abs(item);
        }

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
    }
}
