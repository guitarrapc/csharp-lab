```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **752.8 ns** |   **517.63 ns** |  **28.37 ns** |   **720.1 ns** |   **771.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   721.1 ns |   383.80 ns |  21.04 ns |   698.9 ns |   740.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   696.9 ns |   207.30 ns |  11.36 ns |   684.5 ns |   706.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   717.4 ns |   130.87 ns |   7.17 ns |   710.2 ns |   724.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   706.1 ns |    91.79 ns |   5.03 ns |   700.5 ns |   710.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,198.0 ns** |   **213.38 ns** |  **11.70 ns** | **2,186.2 ns** | **2,209.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,116.4 ns | 1,572.46 ns |  86.19 ns | 2,057.3 ns | 2,215.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,055.9 ns | 1,351.31 ns |  74.07 ns | 2,010.0 ns | 2,141.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,167.3 ns |   961.89 ns |  52.72 ns | 2,106.8 ns | 2,203.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,144.9 ns | 2,005.93 ns | 109.95 ns | 2,018.1 ns | 2,214.1 ns | 0.0343 | 0.0305 |   3.07 KB |
