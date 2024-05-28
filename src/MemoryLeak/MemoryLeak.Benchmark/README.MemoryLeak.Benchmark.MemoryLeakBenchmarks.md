```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **778.0 ns** |   **351.8 ns** | **19.28 ns** |   **763.1 ns** |   **799.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   730.7 ns |   548.2 ns | 30.05 ns |   699.5 ns |   759.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   721.0 ns |   596.8 ns | 32.71 ns |   697.8 ns |   758.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   792.6 ns |   293.6 ns | 16.09 ns |   774.5 ns |   805.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   757.9 ns |   347.9 ns | 19.07 ns |   738.5 ns |   776.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,350.4 ns** |   **543.6 ns** | **29.80 ns** | **2,317.2 ns** | **2,374.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,211.0 ns | 1,108.5 ns | 60.76 ns | 2,164.7 ns | 2,279.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,169.1 ns | 1,662.7 ns | 91.14 ns | 2,105.6 ns | 2,273.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,332.2 ns |   983.9 ns | 53.93 ns | 2,275.3 ns | 2,382.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,230.4 ns | 1,321.6 ns | 72.44 ns | 2,149.8 ns | 2,290.1 ns | 0.0343 | 0.0305 |   3.07 KB |
