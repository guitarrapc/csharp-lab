```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **723.3 ns** |   **596.6 ns** |  **32.70 ns** |   **704.3 ns** |   **761.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   707.4 ns |   269.2 ns |  14.76 ns |   690.5 ns |   717.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   705.4 ns |   129.4 ns |   7.09 ns |   698.4 ns |   712.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   710.5 ns |   247.8 ns |  13.58 ns |   694.8 ns |   718.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   704.1 ns |   482.2 ns |  26.43 ns |   677.5 ns |   730.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,343.6 ns** | **3,845.5 ns** | **210.79 ns** | **7,117.0 ns** | **7,533.9 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,194.0 ns |   120.5 ns |   6.61 ns | 7,187.5 ns | 7,200.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 6,872.7 ns | 4,099.5 ns | 224.71 ns | 6,685.2 ns | 7,121.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,265.2 ns | 1,222.3 ns |  67.00 ns | 7,226.2 ns | 7,342.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,148.8 ns | 7,017.5 ns | 384.65 ns | 6,752.3 ns | 7,520.4 ns | 0.1221 | 0.1144 |  10.23 KB |
