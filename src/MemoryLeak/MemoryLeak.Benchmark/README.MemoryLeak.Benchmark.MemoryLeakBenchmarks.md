```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **776.7 ns** |   **612.1 ns** |  **33.55 ns** |   **746.6 ns** |   **812.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   766.7 ns |   307.5 ns |  16.86 ns |   752.2 ns |   785.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   716.5 ns |   543.7 ns |  29.80 ns |   683.7 ns |   741.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   768.5 ns |   739.9 ns |  40.56 ns |   728.9 ns |   809.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   753.7 ns |   765.1 ns |  41.94 ns |   705.4 ns |   780.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,342.4 ns** | **2,023.9 ns** | **110.94 ns** | **2,220.8 ns** | **2,438.2 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,186.1 ns | 1,784.3 ns |  97.80 ns | 2,108.3 ns | 2,295.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,124.4 ns | 2,267.0 ns | 124.26 ns | 1,989.7 ns | 2,234.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,290.1 ns | 1,376.1 ns |  75.43 ns | 2,203.3 ns | 2,339.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,202.6 ns |   948.8 ns |  52.01 ns | 2,142.6 ns | 2,234.6 ns | 0.0343 | 0.0305 |   3.07 KB |
