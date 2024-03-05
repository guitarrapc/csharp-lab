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
| **AllocateStringStatic** | **1**      |   **778.7 ns** |   **345.42 ns** |  **18.93 ns** |   **756.9 ns** |   **790.3 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   758.1 ns |   533.69 ns |  29.25 ns |   741.1 ns |   791.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   732.0 ns |    35.82 ns |   1.96 ns |   729.9 ns |   733.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   740.0 ns |   425.03 ns |  23.30 ns |   713.6 ns |   757.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   740.3 ns |   546.40 ns |  29.95 ns |   709.5 ns |   769.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,238.4 ns** | **1,212.39 ns** |  **66.46 ns** | **2,191.7 ns** | **2,314.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,127.9 ns |   185.61 ns |  10.17 ns | 2,120.7 ns | 2,139.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,185.6 ns |   715.27 ns |  39.21 ns | 2,141.7 ns | 2,217.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,289.6 ns |   738.85 ns |  40.50 ns | 2,252.0 ns | 2,332.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,157.6 ns | 2,081.82 ns | 114.11 ns | 2,063.8 ns | 2,284.7 ns | 0.0343 | 0.0305 |   3.07 KB |
