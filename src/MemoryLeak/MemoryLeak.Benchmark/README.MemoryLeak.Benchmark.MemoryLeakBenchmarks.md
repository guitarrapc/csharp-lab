```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **733.5 ns** |   **551.1 ns** |  **30.21 ns** |   **700.4 ns** |   **759.6 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   741.2 ns |   265.2 ns |  14.54 ns |   730.3 ns |   757.7 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   670.6 ns |   735.5 ns |  40.31 ns |   642.2 ns |   716.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   718.4 ns |   920.1 ns |  50.43 ns |   661.7 ns |   758.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   702.6 ns |   929.7 ns |  50.96 ns |   645.5 ns |   743.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,060.9 ns** |   **176.3 ns** |   **9.66 ns** | **2,050.0 ns** | **2,068.6 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,151.7 ns | 1,599.6 ns |  87.68 ns | 2,050.5 ns | 2,205.8 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,018.5 ns | 2,684.6 ns | 147.15 ns | 1,920.2 ns | 2,187.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,230.6 ns |   244.7 ns |  13.41 ns | 2,219.6 ns | 2,245.5 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 1,949.0 ns |   338.3 ns |  18.54 ns | 1,932.9 ns | 1,969.3 ns | 0.1869 | 0.1831 |   3.07 KB |
