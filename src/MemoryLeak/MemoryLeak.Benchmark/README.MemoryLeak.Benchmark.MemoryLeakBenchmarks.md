```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **726.0 ns** |   **516.60 ns** | **28.32 ns** |   **701.0 ns** |   **756.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   776.8 ns |   344.85 ns | 18.90 ns |   759.6 ns |   797.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   716.0 ns |    87.98 ns |  4.82 ns |   711.4 ns |   721.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   730.4 ns |   597.19 ns | 32.73 ns |   692.6 ns |   750.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   723.2 ns |   221.60 ns | 12.15 ns |   714.3 ns |   737.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,197.9 ns** | **1,308.93 ns** | **71.75 ns** | **2,122.8 ns** | **2,265.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,141.2 ns | 1,698.62 ns | 93.11 ns | 2,043.2 ns | 2,228.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,108.3 ns |   958.87 ns | 52.56 ns | 2,065.8 ns | 2,167.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,195.1 ns | 1,430.96 ns | 78.44 ns | 2,116.2 ns | 2,273.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,146.1 ns |   666.88 ns | 36.55 ns | 2,115.8 ns | 2,186.7 ns | 0.0343 | 0.0305 |   3.07 KB |
