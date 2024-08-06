```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **760.5 ns** |   **113.1 ns** |   **6.20 ns** |   **755.5 ns** |   **767.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   749.0 ns |   645.6 ns |  35.39 ns |   718.5 ns |   787.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   738.8 ns |   418.3 ns |  22.93 ns |   715.6 ns |   761.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   764.0 ns |   482.7 ns |  26.46 ns |   737.2 ns |   790.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   742.3 ns |   531.1 ns |  29.11 ns |   724.7 ns |   775.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,208.9 ns** |   **737.4 ns** |  **40.42 ns** | **2,165.5 ns** | **2,245.4 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,193.2 ns | 1,485.4 ns |  81.42 ns | 2,101.1 ns | 2,255.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,179.2 ns | 2,129.3 ns | 116.72 ns | 2,090.1 ns | 2,311.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,239.0 ns | 1,889.2 ns | 103.55 ns | 2,134.8 ns | 2,341.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,160.2 ns |   459.0 ns |  25.16 ns | 2,138.3 ns | 2,187.7 ns | 0.0343 | 0.0305 |   3.07 KB |
