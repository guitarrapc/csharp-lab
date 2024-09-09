```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **746.9 ns** |   **194.03 ns** | **10.64 ns** |   **735.1 ns** |   **755.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   724.2 ns |   386.45 ns | 21.18 ns |   704.1 ns |   746.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   712.7 ns |   332.77 ns | 18.24 ns |   699.6 ns |   733.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   743.7 ns |    55.12 ns |  3.02 ns |   741.5 ns |   747.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   705.4 ns |   250.17 ns | 13.71 ns |   689.6 ns |   714.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,198.3 ns** | **1,111.97 ns** | **60.95 ns** | **2,160.6 ns** | **2,268.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,160.8 ns |   635.45 ns | 34.83 ns | 2,133.0 ns | 2,199.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,051.3 ns |   915.96 ns | 50.21 ns | 2,012.8 ns | 2,108.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,141.2 ns | 1,142.80 ns | 62.64 ns | 2,084.9 ns | 2,208.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,138.9 ns | 1,313.44 ns | 71.99 ns | 2,055.9 ns | 2,185.1 ns | 0.0343 | 0.0305 |   3.07 KB |
