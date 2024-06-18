```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **732.2 ns** |   **431.8 ns** | **23.67 ns** |   **710.0 ns** |   **757.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   707.1 ns |   684.6 ns | 37.53 ns |   682.5 ns |   750.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   697.2 ns |   323.5 ns | 17.73 ns |   677.1 ns |   710.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   740.4 ns |   187.5 ns | 10.28 ns |   728.6 ns |   746.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   709.1 ns |   847.1 ns | 46.43 ns |   680.7 ns |   762.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,291.4 ns** | **1,253.2 ns** | **68.69 ns** | **2,213.0 ns** | **2,341.1 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,159.9 ns | 1,109.2 ns | 60.80 ns | 2,093.7 ns | 2,213.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,071.3 ns | 1,768.3 ns | 96.93 ns | 1,989.5 ns | 2,178.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,170.0 ns |   829.9 ns | 45.49 ns | 2,124.2 ns | 2,215.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,146.6 ns | 1,700.8 ns | 93.23 ns | 2,042.6 ns | 2,222.7 ns | 0.0343 | 0.0305 |   3.07 KB |
