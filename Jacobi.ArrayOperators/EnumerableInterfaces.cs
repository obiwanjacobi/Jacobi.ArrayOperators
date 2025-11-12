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
        public int Compare(IEnumerable<T> other)
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
            => first.Compare(other) > 0;
        public static bool operator <(IEnumerable<T> first, IEnumerable<T> other)
            => first.Compare(other) < 0;
        public static bool operator >=(IEnumerable<T> first, IEnumerable<T> other)
            => first.Compare(other) >= 0;
        public static bool operator <=(IEnumerable<T> first, IEnumerable<T> other)
            => first.Compare(other) <= 0;
    }
}
