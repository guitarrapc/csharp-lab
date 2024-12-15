```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **759.6 ns** |   **574.8 ns** | **31.51 ns** |   **735.3 ns** |   **795.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   763.1 ns |   548.8 ns | 30.08 ns |   730.1 ns |   789.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   740.1 ns |   183.4 ns | 10.05 ns |   730.2 ns |   750.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   739.7 ns |   115.6 ns |  6.33 ns |   733.0 ns |   745.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   732.6 ns |   516.4 ns | 28.31 ns |   708.3 ns |   763.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,279.6 ns** |   **422.5 ns** | **23.16 ns** | **2,257.6 ns** | **2,303.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,179.3 ns | 1,185.2 ns | 64.97 ns | 2,124.0 ns | 2,250.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,203.4 ns |   823.7 ns | 45.15 ns | 2,159.0 ns | 2,249.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,228.1 ns | 1,276.7 ns | 69.98 ns | 2,163.2 ns | 2,302.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,158.7 ns |   964.0 ns | 52.84 ns | 2,102.4 ns | 2,207.3 ns | 0.0343 | 0.0305 |   3.07 KB |
