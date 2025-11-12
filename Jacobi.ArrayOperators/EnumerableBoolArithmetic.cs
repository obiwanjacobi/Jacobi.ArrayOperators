namespace Jacobi.ArrayOperators;

public static class EnumerableBoolArithmetic
{
    extension(IEnumerable<bool>)
    {
        public static IEnumerable<bool> operator &(IEnumerable<bool> source, IEnumerable<bool> other)
        {
            List<bool> result = [];
            using var enum1 = source.GetEnumerator();
            using var enum2 = other.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 || !has2)
                    return result;
                result.Add(enum1.Current & enum2.Current);
            }
        }
        public static IEnumerable<bool> operator |(IEnumerable<bool> source, IEnumerable<bool> other)
        {
            List<bool> result = [];
            using var enum1 = source.GetEnumerator();
            using var enum2 = other.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 || !has2)
                    return result;
                result.Add(enum1.Current | enum2.Current);
            }
        }
        public static IEnumerable<bool> operator ^(IEnumerable<bool> source, IEnumerable<bool> other)
        {
            List<bool> result = [];
            using var enum1 = source.GetEnumerator();
            using var enum2 = other.GetEnumerator();
            while (true)
            {
                var has1 = enum1.MoveNext();
                var has2 = enum2.MoveNext();
                if (!has1 || !has2)
                    return result;
                result.Add(enum1.Current ^ enum2.Current);
            }
        }

        public static IEnumerable<bool> operator !(IEnumerable<bool> source)
        {
            foreach (var item in source)
                yield return !item;
        }

        public static bool operator true(IEnumerable<bool> source)
        {
            foreach (var item in source)
                if (!item) return false;

            return true;
        }
        public static bool operator false(IEnumerable<bool> source)
        {
            foreach (var item in source)
                if (item) return false;

            return true;
        }
    }
}
