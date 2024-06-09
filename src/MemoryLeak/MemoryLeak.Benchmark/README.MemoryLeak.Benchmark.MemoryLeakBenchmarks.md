```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **738.1 ns** |   **364.9 ns** | **20.00 ns** |   **724.0 ns** |   **761.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   717.1 ns |   130.5 ns |  7.15 ns |   709.6 ns |   723.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   703.1 ns |   284.6 ns | 15.60 ns |   685.1 ns |   712.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   760.2 ns |   507.3 ns | 27.81 ns |   742.9 ns |   792.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   727.5 ns |   376.3 ns | 20.63 ns |   704.3 ns |   743.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,218.4 ns** | **1,119.1 ns** | **61.34 ns** | **2,175.8 ns** | **2,288.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,176.6 ns |   400.7 ns | 21.96 ns | 2,153.7 ns | 2,197.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,079.0 ns | 1,782.9 ns | 97.73 ns | 1,971.8 ns | 2,163.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,202.0 ns |   251.1 ns | 13.77 ns | 2,187.8 ns | 2,215.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,208.5 ns | 1,517.0 ns | 83.15 ns | 2,112.7 ns | 2,261.8 ns | 0.0343 | 0.0305 |   3.07 KB |
