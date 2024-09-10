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
| **AllocateStringStatic** | **1**      |   **753.2 ns** |   **818.50 ns** | **44.86 ns** |   **725.1 ns** |   **805.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   730.2 ns |   588.08 ns | 32.23 ns |   696.4 ns |   760.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   724.7 ns |   410.22 ns | 22.49 ns |   701.7 ns |   746.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   718.4 ns |    52.74 ns |  2.89 ns |   715.1 ns |   720.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   718.4 ns |   397.78 ns | 21.80 ns |   693.2 ns |   731.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,248.9 ns** | **1,091.41 ns** | **59.82 ns** | **2,186.9 ns** | **2,306.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,170.7 ns |   728.57 ns | 39.94 ns | 2,142.9 ns | 2,216.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,116.3 ns | 1,805.75 ns | 98.98 ns | 2,057.5 ns | 2,230.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,228.8 ns |   732.13 ns | 40.13 ns | 2,183.0 ns | 2,258.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,132.5 ns |   660.01 ns | 36.18 ns | 2,090.8 ns | 2,155.6 ns | 0.0343 | 0.0305 |   3.07 KB |
