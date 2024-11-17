```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **795.6 ns** |   **224.9 ns** | **12.33 ns** |   **787.4 ns** |   **809.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   770.9 ns |   406.1 ns | 22.26 ns |   746.2 ns |   789.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   739.7 ns |   298.9 ns | 16.38 ns |   722.5 ns |   755.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   792.9 ns |   606.1 ns | 33.22 ns |   766.8 ns |   830.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   756.2 ns |   243.3 ns | 13.33 ns |   744.3 ns |   770.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,294.7 ns** |   **686.8 ns** | **37.64 ns** | **2,251.2 ns** | **2,317.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,176.9 ns | 1,473.9 ns | 80.79 ns | 2,084.3 ns | 2,233.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,159.8 ns |   909.5 ns | 49.85 ns | 2,105.9 ns | 2,204.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,228.5 ns | 1,295.6 ns | 71.01 ns | 2,161.0 ns | 2,302.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,192.8 ns | 1,585.4 ns | 86.90 ns | 2,102.0 ns | 2,275.1 ns | 0.0343 | 0.0305 |   3.07 KB |
