```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **755.2 ns** |    **75.90 ns** |  **4.16 ns** |   **752.4 ns** |   **760.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   773.7 ns |   719.88 ns | 39.46 ns |   728.3 ns |   799.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   747.7 ns |   508.22 ns | 27.86 ns |   724.9 ns |   778.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   742.9 ns |   185.92 ns | 10.19 ns |   735.1 ns |   754.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   728.7 ns |   182.11 ns |  9.98 ns |   722.2 ns |   740.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,279.0 ns** | **1,746.93 ns** | **95.76 ns** | **2,168.9 ns** | **2,342.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,184.0 ns | 1,075.20 ns | 58.94 ns | 2,140.4 ns | 2,251.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,195.6 ns | 1,553.85 ns | 85.17 ns | 2,100.9 ns | 2,265.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,237.9 ns |   754.30 ns | 41.35 ns | 2,190.6 ns | 2,266.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,179.1 ns | 1,537.25 ns | 84.26 ns | 2,113.8 ns | 2,274.2 ns | 0.0343 | 0.0305 |   3.07 KB |
