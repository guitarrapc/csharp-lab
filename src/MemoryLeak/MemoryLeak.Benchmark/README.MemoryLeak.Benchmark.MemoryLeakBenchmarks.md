```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **752.0 ns** |    **22.08 ns** |  **1.21 ns** |   **751.1 ns** |   **753.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   726.5 ns |   237.45 ns | 13.02 ns |   712.2 ns |   737.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   707.3 ns |   253.77 ns | 13.91 ns |   694.5 ns |   722.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   758.4 ns |   201.19 ns | 11.03 ns |   749.0 ns |   770.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   723.2 ns |   389.76 ns | 21.36 ns |   702.9 ns |   745.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,216.8 ns** | **1,340.75 ns** | **73.49 ns** | **2,132.9 ns** | **2,269.4 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,210.9 ns | 1,319.43 ns | 72.32 ns | 2,136.7 ns | 2,281.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,123.9 ns | 1,721.37 ns | 94.35 ns | 2,015.1 ns | 2,181.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,180.1 ns |   833.11 ns | 45.67 ns | 2,145.0 ns | 2,231.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,138.8 ns |   727.14 ns | 39.86 ns | 2,092.8 ns | 2,164.3 ns | 0.0343 | 0.0305 |   3.07 KB |
