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
| **AllocateStringStatic** | **1**      |   **725.0 ns** |   **152.4 ns** |   **8.36 ns** |   **715.4 ns** |   **730.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   748.0 ns |   781.8 ns |  42.85 ns |   699.4 ns |   780.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   732.4 ns |   623.9 ns |  34.20 ns |   710.1 ns |   771.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   727.9 ns |   526.4 ns |  28.85 ns |   707.4 ns |   760.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   742.2 ns |   835.3 ns |  45.79 ns |   691.3 ns |   780.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,228.6 ns** | **1,222.8 ns** |  **67.02 ns** | **2,151.2 ns** | **2,268.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,181.9 ns | 1,439.1 ns |  78.88 ns | 2,091.2 ns | 2,234.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,127.4 ns | 1,855.2 ns | 101.69 ns | 2,060.8 ns | 2,244.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,225.5 ns |   850.8 ns |  46.63 ns | 2,180.8 ns | 2,273.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,136.8 ns | 1,009.8 ns |  55.35 ns | 2,088.3 ns | 2,197.1 ns | 0.0343 | 0.0305 |   3.07 KB |
