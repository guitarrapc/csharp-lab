```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **754.3 ns** |   **520.12 ns** | **28.51 ns** |   **721.4 ns** |   **771.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   743.3 ns |   686.12 ns | 37.61 ns |   702.3 ns |   776.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   729.5 ns |   825.19 ns | 45.23 ns |   677.3 ns |   757.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   755.9 ns |    91.52 ns |  5.02 ns |   752.4 ns |   761.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   723.5 ns |   204.50 ns | 11.21 ns |   711.7 ns |   734.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,257.2 ns** | **1,148.71 ns** | **62.96 ns** | **2,184.5 ns** | **2,294.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,204.3 ns | 1,420.48 ns | 77.86 ns | 2,143.7 ns | 2,292.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,148.1 ns | 1,377.03 ns | 75.48 ns | 2,087.9 ns | 2,232.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,225.2 ns | 1,651.65 ns | 90.53 ns | 2,125.6 ns | 2,302.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,142.0 ns | 1,014.18 ns | 55.59 ns | 2,094.9 ns | 2,203.3 ns | 0.0343 | 0.0305 |   3.07 KB |
