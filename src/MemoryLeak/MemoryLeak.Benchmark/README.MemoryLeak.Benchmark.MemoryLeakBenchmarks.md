```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **755.7 ns** |   **654.26 ns** | **35.86 ns** |   **724.4 ns** |   **794.8 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   722.2 ns |    83.60 ns |  4.58 ns |   717.7 ns |   726.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   709.8 ns |   511.58 ns | 28.04 ns |   686.5 ns |   740.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   746.6 ns |   209.63 ns | 11.49 ns |   737.1 ns |   759.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   731.8 ns |   319.70 ns | 17.52 ns |   714.6 ns |   749.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,287.5 ns** | **1,077.68 ns** | **59.07 ns** | **2,221.7 ns** | **2,335.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,192.6 ns |   919.47 ns | 50.40 ns | 2,138.6 ns | 2,238.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,072.8 ns |   927.41 ns | 50.83 ns | 2,037.2 ns | 2,131.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,154.1 ns | 1,010.86 ns | 55.41 ns | 2,112.0 ns | 2,216.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,159.6 ns |   983.59 ns | 53.91 ns | 2,125.0 ns | 2,221.7 ns | 0.0343 | 0.0305 |   3.07 KB |
