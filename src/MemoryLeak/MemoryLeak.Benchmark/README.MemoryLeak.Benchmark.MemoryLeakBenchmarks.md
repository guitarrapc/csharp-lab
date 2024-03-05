```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **759.4 ns** |   **320.51 ns** |  **17.57 ns** |   **745.4 ns** |   **779.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   758.4 ns |    69.42 ns |   3.80 ns |   755.4 ns |   762.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   712.8 ns |   235.56 ns |  12.91 ns |   704.3 ns |   727.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   726.7 ns |   395.35 ns |  21.67 ns |   703.0 ns |   745.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   744.8 ns |   111.63 ns |   6.12 ns |   738.9 ns |   751.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,292.0 ns** |   **575.36 ns** |  **31.54 ns** | **2,268.8 ns** | **2,327.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,148.0 ns | 1,445.81 ns |  79.25 ns | 2,068.7 ns | 2,227.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,149.9 ns |   147.51 ns |   8.09 ns | 2,143.5 ns | 2,159.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,151.0 ns | 1,085.92 ns |  59.52 ns | 2,096.0 ns | 2,214.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,195.5 ns | 1,946.70 ns | 106.71 ns | 2,094.5 ns | 2,307.1 ns | 0.0343 | 0.0305 |   3.07 KB |
