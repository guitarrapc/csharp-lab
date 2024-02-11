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
| **AllocateStringStatic** | **1**      |   **769.4 ns** |   **918.8 ns** |  **50.36 ns** |   **711.3 ns** |   **800.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   705.9 ns |   463.4 ns |  25.40 ns |   686.5 ns |   734.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   701.8 ns |   275.0 ns |  15.08 ns |   684.5 ns |   711.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   733.1 ns |   291.2 ns |  15.96 ns |   718.0 ns |   749.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   711.9 ns |   535.3 ns |  29.34 ns |   694.4 ns |   745.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,772.3 ns** | **1,624.3 ns** |  **89.03 ns** | **7,678.9 ns** | **7,856.2 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,359.7 ns | 2,257.9 ns | 123.76 ns | 7,229.4 ns | 7,475.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,191.9 ns | 1,208.4 ns |  66.24 ns | 7,128.4 ns | 7,260.6 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,381.3 ns |   633.7 ns |  34.73 ns | 7,343.5 ns | 7,411.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,316.6 ns | 2,800.8 ns | 153.52 ns | 7,209.3 ns | 7,492.4 ns | 0.1221 | 0.1144 |  10.23 KB |
