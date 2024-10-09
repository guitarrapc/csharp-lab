```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **740.8 ns** |   **385.79 ns** |  **21.15 ns** |   **721.7 ns** |   **763.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   750.8 ns |   662.95 ns |  36.34 ns |   710.5 ns |   781.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   703.3 ns |   338.61 ns |  18.56 ns |   686.8 ns |   723.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   734.3 ns |   364.98 ns |  20.01 ns |   711.5 ns |   748.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   733.7 ns |    85.50 ns |   4.69 ns |   729.3 ns |   738.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,256.2 ns** | **1,580.30 ns** |  **86.62 ns** | **2,156.8 ns** | **2,315.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,110.3 ns | 1,688.08 ns |  92.53 ns | 2,048.3 ns | 2,216.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,105.2 ns | 1,159.18 ns |  63.54 ns | 2,048.7 ns | 2,174.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,159.2 ns | 2,402.31 ns | 131.68 ns | 2,073.0 ns | 2,310.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,123.0 ns | 1,257.20 ns |  68.91 ns | 2,048.7 ns | 2,184.8 ns | 0.0343 | 0.0305 |   3.07 KB |
