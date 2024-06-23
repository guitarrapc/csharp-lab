```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **773.2 ns** |   **265.6 ns** |  **14.56 ns** |   **759.7 ns** |   **788.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   731.0 ns |   702.2 ns |  38.49 ns |   702.2 ns |   774.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   718.5 ns |   386.6 ns |  21.19 ns |   699.4 ns |   741.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   742.2 ns |   380.9 ns |  20.88 ns |   722.1 ns |   763.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   707.3 ns |   178.2 ns |   9.77 ns |   696.5 ns |   715.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,215.3 ns** | **1,063.9 ns** |  **58.32 ns** | **2,148.2 ns** | **2,253.6 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,187.2 ns | 1,254.6 ns |  68.77 ns | 2,142.9 ns | 2,266.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,150.1 ns | 1,011.7 ns |  55.45 ns | 2,093.8 ns | 2,204.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,242.2 ns |   597.4 ns |  32.75 ns | 2,218.0 ns | 2,279.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,164.3 ns | 1,918.6 ns | 105.17 ns | 2,103.0 ns | 2,285.7 ns | 0.0343 | 0.0305 |   3.07 KB |
