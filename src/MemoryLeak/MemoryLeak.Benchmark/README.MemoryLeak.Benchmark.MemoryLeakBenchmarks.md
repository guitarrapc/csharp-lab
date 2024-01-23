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
| **AllocateStringStatic** | **1**      |   **748.2 ns** |   **187.1 ns** |  **10.25 ns** |   **739.2 ns** |   **759.3 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   711.0 ns |   449.9 ns |  24.66 ns |   689.6 ns |   737.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   702.2 ns |   761.3 ns |  41.73 ns |   664.6 ns |   747.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   720.8 ns |   294.8 ns |  16.16 ns |   702.3 ns |   732.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   706.9 ns |   426.6 ns |  23.38 ns |   689.5 ns |   733.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,565.8 ns** | **1,652.5 ns** |  **90.58 ns** | **7,462.0 ns** | **7,628.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,181.1 ns | 5,628.1 ns | 308.50 ns | 6,830.1 ns | 7,409.0 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 6,963.4 ns | 5,017.4 ns | 275.02 ns | 6,788.3 ns | 7,280.4 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,433.8 ns | 1,144.6 ns |  62.74 ns | 7,376.7 ns | 7,501.0 ns | 0.1297 | 0.1221 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,325.6 ns | 2,158.5 ns | 118.31 ns | 7,222.4 ns | 7,454.7 ns | 0.1221 | 0.1144 |  10.23 KB |
