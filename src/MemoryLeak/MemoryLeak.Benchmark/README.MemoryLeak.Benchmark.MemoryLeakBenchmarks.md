```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **721.6 ns** |   **280.18 ns** |  **15.36 ns** |   **710.3 ns** |   **739.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   690.2 ns |   228.15 ns |  12.51 ns |   677.4 ns |   702.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   698.9 ns |    69.02 ns |   3.78 ns |   695.1 ns |   702.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   712.2 ns |   416.92 ns |  22.85 ns |   686.9 ns |   731.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   693.0 ns |   452.02 ns |  24.78 ns |   676.9 ns |   721.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,324.6 ns** | **4,607.34 ns** | **252.54 ns** | **7,046.3 ns** | **7,539.3 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,322.6 ns | 2,840.31 ns | 155.69 ns | 7,156.8 ns | 7,465.7 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 6,939.4 ns | 3,201.34 ns | 175.48 ns | 6,815.2 ns | 7,140.2 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,116.5 ns | 3,151.27 ns | 172.73 ns | 6,970.3 ns | 7,307.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,141.6 ns | 2,040.42 ns | 111.84 ns | 7,028.7 ns | 7,252.3 ns | 0.1221 | 0.1144 |  10.23 KB |
