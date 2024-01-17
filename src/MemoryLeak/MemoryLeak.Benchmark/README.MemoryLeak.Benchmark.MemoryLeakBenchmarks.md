```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **744.9 ns** |    **90.45 ns** |   **4.96 ns** |   **739.7 ns** |   **749.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   732.5 ns |   139.93 ns |   7.67 ns |   723.7 ns |   737.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   692.9 ns |   118.91 ns |   6.52 ns |   686.1 ns |   699.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   732.2 ns |   197.41 ns |  10.82 ns |   721.3 ns |   742.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   716.3 ns |   120.59 ns |   6.61 ns |   709.9 ns |   723.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,511.6 ns** |   **434.02 ns** |  **23.79 ns** | **7,486.4 ns** | **7,533.6 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,117.8 ns | 3,059.48 ns | 167.70 ns | 6,924.6 ns | 7,225.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,046.4 ns | 3,833.71 ns | 210.14 ns | 6,852.2 ns | 7,269.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,145.6 ns | 1,900.49 ns | 104.17 ns | 7,062.4 ns | 7,262.5 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,172.6 ns | 1,539.20 ns |  84.37 ns | 7,083.0 ns | 7,250.6 ns | 0.1221 | 0.1144 |  10.23 KB |
