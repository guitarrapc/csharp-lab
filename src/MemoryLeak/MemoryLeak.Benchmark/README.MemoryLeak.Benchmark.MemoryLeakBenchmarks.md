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
| **AllocateStringStatic** | **1**      |   **772.5 ns** |   **311.20 ns** | **17.06 ns** |   **753.7 ns** |   **787.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   740.0 ns |   459.93 ns | 25.21 ns |   711.6 ns |   759.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   721.6 ns |    83.74 ns |  4.59 ns |   718.7 ns |   726.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   745.1 ns |   247.94 ns | 13.59 ns |   736.0 ns |   760.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   713.8 ns |   252.67 ns | 13.85 ns |   699.9 ns |   727.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,233.5 ns** | **1,566.73 ns** | **85.88 ns** | **2,154.4 ns** | **2,324.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,197.8 ns |   749.69 ns | 41.09 ns | 2,167.4 ns | 2,244.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,120.4 ns |   781.01 ns | 42.81 ns | 2,073.8 ns | 2,158.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,203.3 ns |   842.30 ns | 46.17 ns | 2,175.4 ns | 2,256.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,163.5 ns |   300.86 ns | 16.49 ns | 2,147.2 ns | 2,180.1 ns | 0.0343 | 0.0305 |   3.07 KB |
