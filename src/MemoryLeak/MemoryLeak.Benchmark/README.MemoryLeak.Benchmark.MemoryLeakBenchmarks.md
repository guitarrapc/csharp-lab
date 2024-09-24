```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **782.7 ns** |   **565.3 ns** |  **30.98 ns** |   **758.4 ns** |   **817.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   715.3 ns | 1,049.5 ns |  57.53 ns |   672.1 ns |   780.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   699.3 ns |   731.4 ns |  40.09 ns |   661.3 ns |   741.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   739.6 ns |   580.7 ns |  31.83 ns |   708.2 ns |   771.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   712.4 ns |   842.0 ns |  46.15 ns |   680.4 ns |   765.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,163.6 ns** | **2,296.9 ns** | **125.90 ns** | **2,071.4 ns** | **2,307.1 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,191.8 ns | 2,318.7 ns | 127.09 ns | 2,046.5 ns | 2,281.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,060.5 ns | 2,197.4 ns | 120.45 ns | 1,958.6 ns | 2,193.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,138.1 ns | 1,740.3 ns |  95.39 ns | 2,081.5 ns | 2,248.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,047.4 ns |   591.6 ns |  32.43 ns | 2,019.0 ns | 2,082.7 ns | 0.0343 | 0.0305 |   3.07 KB |
