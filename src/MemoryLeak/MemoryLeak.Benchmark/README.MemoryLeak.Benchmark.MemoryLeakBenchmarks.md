```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **774.0 ns** |   **644.62 ns** |  **35.33 ns** |   **744.5 ns** |   **813.2 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   734.0 ns |   847.13 ns |  46.43 ns |   681.5 ns |   769.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   698.5 ns |   841.14 ns |  46.11 ns |   648.3 ns |   738.9 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   728.8 ns |   768.47 ns |  42.12 ns |   682.2 ns |   764.2 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   703.7 ns |   806.59 ns |  44.21 ns |   654.3 ns |   739.7 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,065.5 ns** |   **485.61 ns** |  **26.62 ns** | **2,041.5 ns** | **2,094.1 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,208.3 ns | 2,542.10 ns | 139.34 ns | 2,051.1 ns | 2,316.6 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,161.4 ns |   702.79 ns |  38.52 ns | 2,121.7 ns | 2,198.6 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,275.0 ns |   842.44 ns |  46.18 ns | 2,241.4 ns | 2,327.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,009.9 ns |    72.11 ns |   3.95 ns | 2,005.5 ns | 2,013.2 ns | 0.1869 | 0.1831 |   3.07 KB |
