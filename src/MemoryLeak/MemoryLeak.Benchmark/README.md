# MemoryLeak.Benchmark

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|               Method |  N |      Mean |     Error |    StdDev |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|--------------------- |--- |----------:|----------:|----------:|-------:|-------:|-------:|----------:|
| AllocateStringStatic | 10 | 10.043 μs | 42.337 μs | 2.3206 μs | 0.4272 | 0.4120 | 0.0153 |     10 KB |
|       AllocateString | 10 |  7.952 μs |  3.013 μs | 0.1652 μs | 0.4272 | 0.4120 | 0.0153 |     10 KB |
|          AllocateLoH | 10 |  7.780 μs |  4.047 μs | 0.2219 μs | 0.4272 | 0.4120 | 0.0153 |     10 KB |
|        AllocateArray | 10 |  8.461 μs |  3.028 μs | 0.1660 μs | 0.4272 | 0.4120 | 0.0153 |     10 KB |
|    AllocateArrayPool | 10 |  8.370 μs |  3.317 μs | 0.1818 μs | 0.4272 | 0.4120 | 0.0153 |     10 KB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|            Method |  N |       Mean |    Error |  StdDev | Allocated |
|------------------ |--- |-----------:|---------:|--------:|----------:|
|        RentReturn | 10 |   774.2 ns |  6.20 ns | 0.34 ns |         - |
| AllocateArrayPool | 10 | 1,289.5 ns | 63.33 ns | 3.47 ns |         - |
