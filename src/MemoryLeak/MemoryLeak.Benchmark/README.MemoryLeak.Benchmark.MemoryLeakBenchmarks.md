```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **741.1 ns** |   **601.12 ns** |  **32.95 ns** |   **718.6 ns** |   **778.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   722.1 ns |   437.66 ns |  23.99 ns |   694.9 ns |   740.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   695.4 ns |   440.11 ns |  24.12 ns |   671.5 ns |   719.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   709.1 ns |   502.74 ns |  27.56 ns |   687.0 ns |   739.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   723.9 ns |    93.71 ns |   5.14 ns |   720.1 ns |   729.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,595.5 ns** | **1,174.54 ns** |  **64.38 ns** | **7,537.4 ns** | **7,664.7 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,301.2 ns |   874.27 ns |  47.92 ns | 7,260.2 ns | 7,353.9 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,049.2 ns | 1,410.70 ns |  77.33 ns | 6,961.2 ns | 7,106.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,445.9 ns | 2,934.36 ns | 160.84 ns | 7,282.8 ns | 7,604.4 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,216.1 ns |   550.98 ns |  30.20 ns | 7,181.3 ns | 7,235.8 ns | 0.1221 | 0.1144 |  10.23 KB |
