```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **752.3 ns** |   **606.4 ns** |  **33.24 ns** |   **714.0 ns** |   **773.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   728.9 ns |   459.5 ns |  25.19 ns |   708.7 ns |   757.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   692.8 ns |   448.2 ns |  24.57 ns |   671.1 ns |   719.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   742.1 ns |   710.9 ns |  38.97 ns |   700.0 ns |   776.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   726.8 ns |   663.9 ns |  36.39 ns |   700.3 ns |   768.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,660.4 ns** | **4,109.5 ns** | **225.25 ns** | **7,417.1 ns** | **7,861.8 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,387.8 ns | 2,717.2 ns | 148.94 ns | 7,300.3 ns | 7,559.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,152.4 ns | 2,155.1 ns | 118.13 ns | 7,075.1 ns | 7,288.4 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,445.4 ns | 3,005.6 ns | 164.75 ns | 7,337.2 ns | 7,635.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,028.3 ns | 2,483.8 ns | 136.15 ns | 6,938.6 ns | 7,184.9 ns | 0.1221 | 0.1144 |  10.23 KB |
