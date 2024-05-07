```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **763.4 ns** |   **400.0 ns** | **21.93 ns** |   **744.3 ns** |   **787.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   734.3 ns |   350.4 ns | 19.21 ns |   715.1 ns |   753.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   745.7 ns |   132.7 ns |  7.28 ns |   738.5 ns |   753.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   752.8 ns |   468.9 ns | 25.70 ns |   723.2 ns |   770.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   733.5 ns |   647.6 ns | 35.49 ns |   694.5 ns |   764.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,346.4 ns** | **1,125.1 ns** | **61.67 ns** | **2,278.5 ns** | **2,398.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,163.3 ns | 1,251.0 ns | 68.57 ns | 2,119.2 ns | 2,242.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,201.2 ns | 1,581.2 ns | 86.67 ns | 2,127.3 ns | 2,296.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,333.8 ns |   714.2 ns | 39.15 ns | 2,296.6 ns | 2,374.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,264.2 ns |   919.3 ns | 50.39 ns | 2,206.2 ns | 2,296.5 ns | 0.0343 | 0.0305 |   3.07 KB |
