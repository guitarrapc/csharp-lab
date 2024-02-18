```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **753.5 ns** |   **576.10 ns** |  **31.58 ns** |   **717.1 ns** |   **772.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   702.4 ns |   285.00 ns |  15.62 ns |   688.2 ns |   719.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   721.1 ns |    40.49 ns |   2.22 ns |   718.7 ns |   723.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   737.4 ns |   561.30 ns |  30.77 ns |   704.6 ns |   765.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   733.6 ns |   267.32 ns |  14.65 ns |   722.2 ns |   750.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,556.9 ns** | **3,257.90 ns** | **178.58 ns** | **7,385.4 ns** | **7,741.8 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,342.0 ns |   545.03 ns |  29.88 ns | 7,310.2 ns | 7,369.5 ns | 0.1297 | 0.1221 |  10.23 KB |
| AllocateLoH          | 10     | 6,995.7 ns | 6,209.61 ns | 340.37 ns | 6,656.8 ns | 7,337.5 ns | 0.1297 | 0.1221 |  10.23 KB |
| AllocateArray        | 10     | 7,379.8 ns | 3,653.70 ns | 200.27 ns | 7,151.4 ns | 7,525.4 ns | 0.1297 | 0.1221 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,346.6 ns | 2,033.40 ns | 111.46 ns | 7,272.5 ns | 7,474.8 ns | 0.1221 | 0.1144 |  10.23 KB |
