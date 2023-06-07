# MemoryLeak.Benchmark

Environment

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```

|                 Method |   N |       Mean |       Error |      StdDev |      Median |   Gen 0 |   Gen 1 |  Gen 2 | Allocated |
|----------------------- |---- |-----------:|------------:|------------:|------------:|--------:|--------:|-------:|----------:|
|   **AllocateStringStatic** |  **10** |   **125.3 μs** |    **838.0 μs** |    **45.94 μs** |   **121.15 μs** |  **4.0283** |  **3.9063** | **0.1221** |    **100 KB** |
|         AllocateString |  10 |   109.9 μs |    922.8 μs |    50.58 μs |    81.29 μs |  4.0283 |  3.9063 | 0.1221 |    100 KB |
|            AllocateLoH |  10 |   100.9 μs |    871.3 μs |    47.76 μs |    74.05 μs |  4.0283 |  3.9063 | 0.1221 |    100 KB |
| AllocateArrayPoolArray |  10 |   132.2 μs |  1,141.9 μs |    62.59 μs |    97.86 μs |  4.0283 |  3.9063 | 0.1221 |    101 KB |
|   **AllocateStringStatic** | **100** | **2,670.6 μs** | **30,611.7 μs** | **1,677.93 μs** | **2,803.40 μs** | **40.0391** | **39.0625** | **0.9766** |  **1,002 KB** |
|         AllocateString | 100 | 2,568.4 μs | 34,990.6 μs | 1,917.95 μs | 2,058.78 μs | 40.0391 | 39.0625 | 0.9766 |  1,002 KB |
|            AllocateLoH | 100 | 2,368.3 μs | 32,671.5 μs | 1,790.84 μs | 1,869.77 μs | 40.0391 | 39.0625 | 0.9766 |  1,002 KB |
| AllocateArrayPoolArray | 100 |   887.0 μs |    962.0 μs |    52.73 μs |   858.68 μs | 39.0625 | 37.1094 |      - |  1,009 KB |
