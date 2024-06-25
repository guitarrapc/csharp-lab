```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **753.8 ns** |   **614.1 ns** |  **33.66 ns** |   **716.3 ns** |   **781.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   733.5 ns |   147.6 ns |   8.09 ns |   726.5 ns |   742.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   691.1 ns |   571.9 ns |  31.35 ns |   672.5 ns |   727.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   738.7 ns |   344.9 ns |  18.91 ns |   725.1 ns |   760.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   721.3 ns |   424.1 ns |  23.24 ns |   697.7 ns |   744.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,244.6 ns** | **1,848.4 ns** | **101.32 ns** | **2,127.7 ns** | **2,306.0 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,095.4 ns | 1,495.9 ns |  82.00 ns | 2,046.1 ns | 2,190.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,116.1 ns |   141.5 ns |   7.76 ns | 2,108.9 ns | 2,124.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,107.7 ns | 1,108.0 ns |  60.73 ns | 2,065.6 ns | 2,177.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,157.4 ns | 1,386.7 ns |  76.01 ns | 2,077.0 ns | 2,228.1 ns | 0.0343 | 0.0305 |   3.07 KB |
