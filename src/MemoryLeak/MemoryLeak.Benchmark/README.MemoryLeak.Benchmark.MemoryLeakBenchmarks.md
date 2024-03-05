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
| **AllocateStringStatic** | **1**      |   **795.0 ns** |    **85.40 ns** |   **4.68 ns** |   **791.9 ns** |   **800.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   733.4 ns |   382.74 ns |  20.98 ns |   709.5 ns |   748.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   735.9 ns |   292.56 ns |  16.04 ns |   726.4 ns |   754.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   740.1 ns |   644.73 ns |  35.34 ns |   705.1 ns |   775.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   728.4 ns |   182.06 ns |   9.98 ns |   721.5 ns |   739.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,803.0 ns** | **6,018.58 ns** | **329.90 ns** | **7,462.5 ns** | **8,121.2 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,461.0 ns | 3,179.42 ns | 174.27 ns | 7,344.0 ns | 7,661.3 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,194.3 ns | 1,316.85 ns |  72.18 ns | 7,114.5 ns | 7,255.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,482.3 ns | 1,318.99 ns |  72.30 ns | 7,400.7 ns | 7,538.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,480.2 ns | 4,652.96 ns | 255.04 ns | 7,288.6 ns | 7,769.6 ns | 0.1221 | 0.1144 |  10.23 KB |
