```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **760.7 ns** |   **388.0 ns** | **21.27 ns** |   **737.2 ns** |   **778.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   712.1 ns |   387.1 ns | 21.22 ns |   698.0 ns |   736.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   712.3 ns |   240.3 ns | 13.17 ns |   697.2 ns |   721.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   750.0 ns |   365.3 ns | 20.03 ns |   735.0 ns |   772.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   719.2 ns |   345.6 ns | 18.95 ns |   697.5 ns |   732.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,231.1 ns** | **1,575.6 ns** | **86.36 ns** | **2,139.1 ns** | **2,310.4 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,183.2 ns | 1,697.2 ns | 93.03 ns | 2,081.2 ns | 2,263.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,128.4 ns | 1,070.2 ns | 58.66 ns | 2,062.3 ns | 2,174.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,172.1 ns | 1,446.6 ns | 79.29 ns | 2,104.9 ns | 2,259.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,101.3 ns | 1,009.7 ns | 55.35 ns | 2,038.0 ns | 2,140.7 ns | 0.0343 | 0.0305 |   3.07 KB |
