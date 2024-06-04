```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **764.8 ns** |   **312.1 ns** | **17.11 ns** |   **749.9 ns** |   **783.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   711.0 ns |   475.6 ns | 26.07 ns |   693.3 ns |   740.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   695.1 ns |   402.9 ns | 22.08 ns |   674.8 ns |   718.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   741.5 ns |   149.5 ns |  8.19 ns |   733.0 ns |   749.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   722.8 ns |   339.1 ns | 18.59 ns |   702.9 ns |   739.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,193.9 ns** | **1,317.0 ns** | **72.19 ns** | **2,125.4 ns** | **2,269.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,146.7 ns |   880.2 ns | 48.25 ns | 2,091.9 ns | 2,183.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,056.6 ns | 1,713.2 ns | 93.91 ns | 1,959.5 ns | 2,147.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,164.1 ns | 1,100.9 ns | 60.35 ns | 2,127.9 ns | 2,233.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,115.2 ns |   774.9 ns | 42.47 ns | 2,089.2 ns | 2,164.2 ns | 0.0343 | 0.0305 |   3.07 KB |
