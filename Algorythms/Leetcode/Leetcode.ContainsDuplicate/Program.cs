﻿using BenchmarkDotNet.Running;

namespace Leetcode.ContainsDuplicate
{
    public static class Program
    {
        private static void Main() => BenchmarkRunner.Run<Benchmark>();
    }
}
