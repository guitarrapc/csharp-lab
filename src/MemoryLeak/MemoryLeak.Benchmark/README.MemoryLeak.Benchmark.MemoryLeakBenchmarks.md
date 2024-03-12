```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **769.2 ns** |    **96.78 ns** |   **5.30 ns** |   **764.5 ns** |   **775.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   749.7 ns |   406.96 ns |  22.31 ns |   735.1 ns |   775.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   736.6 ns |   152.34 ns |   8.35 ns |   727.0 ns |   741.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   759.9 ns |   307.47 ns |  16.85 ns |   740.5 ns |   770.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   756.5 ns |   274.88 ns |  15.07 ns |   747.4 ns |   773.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,251.6 ns** | **1,122.79 ns** |  **61.54 ns** | **2,203.2 ns** | **2,320.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,192.8 ns |   894.15 ns |  49.01 ns | 2,154.5 ns | 2,248.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,097.9 ns | 1,124.98 ns |  61.66 ns | 2,027.5 ns | 2,142.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,199.4 ns | 1,224.02 ns |  67.09 ns | 2,126.5 ns | 2,258.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,116.8 ns | 2,368.21 ns | 129.81 ns | 2,036.3 ns | 2,266.6 ns | 0.0343 | 0.0305 |   3.07 KB |
