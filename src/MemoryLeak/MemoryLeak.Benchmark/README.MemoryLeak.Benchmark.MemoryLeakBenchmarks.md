```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **737.6 ns** |   **177.5 ns** |   **9.73 ns** |   **726.7 ns** |   **745.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   723.9 ns |   526.2 ns |  28.84 ns |   694.5 ns |   752.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   695.8 ns |   364.6 ns |  19.99 ns |   681.9 ns |   718.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   731.3 ns |   542.7 ns |  29.74 ns |   697.0 ns |   749.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   735.9 ns |   116.8 ns |   6.40 ns |   728.5 ns |   739.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,237.4 ns** |   **722.9 ns** |  **39.63 ns** | **2,202.6 ns** | **2,280.6 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,116.4 ns | 2,374.6 ns | 130.16 ns | 2,039.6 ns | 2,266.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,068.9 ns | 1,112.5 ns |  60.98 ns | 2,003.9 ns | 2,124.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,260.3 ns | 1,290.1 ns |  70.71 ns | 2,182.2 ns | 2,319.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,118.4 ns |   508.7 ns |  27.88 ns | 2,091.4 ns | 2,147.1 ns | 0.0343 | 0.0305 |   3.07 KB |
