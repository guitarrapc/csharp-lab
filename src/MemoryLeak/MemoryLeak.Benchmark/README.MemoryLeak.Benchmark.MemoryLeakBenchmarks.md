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
| **AllocateStringStatic** | **1**      |   **773.4 ns** |   **218.9 ns** |  **12.00 ns** |   **762.9 ns** |   **786.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   727.9 ns |   476.8 ns |  26.13 ns |   701.4 ns |   753.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   706.2 ns |   644.7 ns |  35.34 ns |   681.1 ns |   746.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   727.6 ns |   440.6 ns |  24.15 ns |   708.3 ns |   754.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   712.6 ns |   268.0 ns |  14.69 ns |   702.1 ns |   729.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,254.4 ns** |   **668.6 ns** |  **36.65 ns** | **2,213.8 ns** | **2,284.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,172.8 ns | 2,037.0 ns | 111.66 ns | 2,045.0 ns | 2,251.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,109.7 ns |   815.6 ns |  44.71 ns | 2,083.7 ns | 2,161.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,206.4 ns | 1,397.6 ns |  76.61 ns | 2,136.4 ns | 2,288.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,146.9 ns |   948.2 ns |  51.97 ns | 2,093.8 ns | 2,197.7 ns | 0.0343 | 0.0305 |   3.07 KB |
