using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using Microsoft.VSDiagnostics;

namespace Jacobi.ArrayOperators.Benchmarks
{
    // For more information on the VS BenchmarkDotNet Diagnosers see https://learn.microsoft.com/visualstudio/profiling/profiling-with-benchmark-dotnet
    [CPUUsageDiagnoser]
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        const int Length = 1_000;
        private int[] _arr1;
        private int[] _arr2;
        private List<int> _list;

        [GlobalSetup]
        public void Setup()
        {
            _arr1 = NewRandomArray(Length);
            _arr2 = NewRandomArray(Length);
            _list = new List<int>(_arr1);
        }

        private static int[] NewRandomArray(int len)
        {
            Random rand = new Random();
            int[] array = new int[len];
            for (int i = 0; i < len; i++)
            {
                array[i] = rand.Next();
            }
            return array;
        }

        [Benchmark]
        public int[] AddArrays()
        {
            var result = _arr1 + _arr2;
            return result;
        }
        [Benchmark]
        public IList<int> AddLists()
        {
            var result = ((IList<int>)_arr1) + ((IList<int>)_arr2);
            // implemented with List<T> so should be cheap.
            return result;
        }
        [Benchmark]
        public IList<int> AddCollection()
        {
            // degrades to IEnumerable implementation
            var result = ((ICollection<int>)_arr1) + ((ICollection<int>)_arr2);
            // implemented with List<T> so should be cheap.
            return result.ToList();
        }
        [Benchmark]
        public IList<int> AddEnumerables()
        {
            var result = ((IEnumerable<int>)_arr1) + ((IEnumerable<int>)_arr2);
            // implemented with List<T> so should be cheap.
            return result.ToList();
        }

        [Benchmark]
        public int[] ArrayMultiplyScalar()
        {
            var result = _arr1 * 3;
            return result;
        }
        [Benchmark]
        public IList<int> ListMultiplyScalar()
        {
            var result = ((IList<int>)_arr1) * 3;
            return result;
        }
        [Benchmark]
        public IList<int> CollectionMultiplyScalar()
        {
            var result = ((ICollection<int>)_arr1) * 3;
            // implemented with List<T> so should be cheap.
            return result.ToList();
        }
        [Benchmark]
        public IList<int> EnumerableMultiplyScalar()
        {
            var result = ((IEnumerable<int>)_arr1) * 3;
            // implemented with List<T> so should be cheap.
            return result.ToList();
        }

        [Benchmark]
        public int[] ArrayShiftLeft()
        {
            var result = _arr1 << 3;
            return result;
        }
        [Benchmark]
        public IList<int> ListShiftLeft()
        {
            var result = ((IList<int>)_arr1) << 3;
            return result;
        }
        [Benchmark]
        public IList<int> CollectionShiftLeft()
        {
            var result = ((ICollection<int>)_arr1) << 3;
            // implemented with List<T> so should be cheap.
            return result.ToList();
        }
        [Benchmark]
        public IList<int> EnumerableShiftLeft()
        {
            var result = ((IEnumerable<int>)_arr1) << 3;
            // implemented with List<T> so should be cheap.
            return result.ToList();
        }

        [Benchmark]
        public int[] ArrayInPlaceScalar()
        {
            _arr1 *= 3;
            return _arr1;
        }
        [Benchmark]
        public IList<int> ListInPlaceScalar()
        {
            _list *= 3;
            return _list;
        }
    }
}
