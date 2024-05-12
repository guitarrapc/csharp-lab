```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **745.6 ns** |   **172.18 ns** |   **9.44 ns** |   **734.8 ns** |   **752.3 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   725.3 ns |   370.14 ns |  20.29 ns |   712.4 ns |   748.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   723.9 ns |   132.45 ns |   7.26 ns |   715.6 ns |   729.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   734.2 ns |   566.59 ns |  31.06 ns |   706.3 ns |   767.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   731.2 ns |    64.38 ns |   3.53 ns |   727.5 ns |   734.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,246.0 ns** | **1,163.38 ns** |  **63.77 ns** | **2,176.1 ns** | **2,301.0 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,141.6 ns | 1,344.61 ns |  73.70 ns | 2,056.5 ns | 2,185.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,135.5 ns | 1,088.29 ns |  59.65 ns | 2,070.1 ns | 2,187.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,259.0 ns | 1,834.59 ns | 100.56 ns | 2,159.8 ns | 2,360.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,136.5 ns |   999.84 ns |  54.80 ns | 2,078.1 ns | 2,186.7 ns | 0.0343 | 0.0305 |   3.07 KB |
