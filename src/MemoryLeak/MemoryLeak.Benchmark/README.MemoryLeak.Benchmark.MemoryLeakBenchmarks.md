```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **767.6 ns** |   **164.68 ns** |  **9.03 ns** |   **757.6 ns** |   **775.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   723.7 ns |   345.49 ns | 18.94 ns |   703.7 ns |   741.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   694.2 ns |   501.49 ns | 27.49 ns |   675.7 ns |   725.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   736.7 ns |   377.41 ns | 20.69 ns |   712.9 ns |   750.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   744.6 ns |    95.26 ns |  5.22 ns |   738.8 ns |   748.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,272.4 ns** |   **868.95 ns** | **47.63 ns** | **2,237.4 ns** | **2,326.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,145.6 ns |   974.10 ns | 53.39 ns | 2,084.9 ns | 2,185.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,111.5 ns | 1,341.81 ns | 73.55 ns | 2,027.1 ns | 2,161.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,163.8 ns |   534.41 ns | 29.29 ns | 2,136.5 ns | 2,194.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,144.3 ns | 1,266.26 ns | 69.41 ns | 2,080.8 ns | 2,218.4 ns | 0.0343 | 0.0305 |   3.07 KB |
