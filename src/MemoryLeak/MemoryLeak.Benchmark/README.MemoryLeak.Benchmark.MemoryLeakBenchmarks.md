```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **773.8 ns** |   **888.1 ns** |  **48.68 ns** |   **729.6 ns** |   **826.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   742.8 ns |   569.2 ns |  31.20 ns |   712.0 ns |   774.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   741.2 ns |   570.3 ns |  31.26 ns |   708.5 ns |   770.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   802.0 ns |   398.4 ns |  21.84 ns |   786.8 ns |   827.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   757.0 ns |   149.4 ns |   8.19 ns |   748.0 ns |   763.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,308.4 ns** | **1,854.9 ns** | **101.67 ns** | **2,231.3 ns** | **2,423.6 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,260.8 ns | 2,193.3 ns | 120.22 ns | 2,123.2 ns | 2,345.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,223.8 ns | 1,473.3 ns |  80.76 ns | 2,142.2 ns | 2,303.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,266.6 ns |   399.4 ns |  21.89 ns | 2,253.0 ns | 2,291.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,228.7 ns | 2,295.7 ns | 125.84 ns | 2,110.5 ns | 2,361.0 ns | 0.0343 | 0.0305 |   3.07 KB |
