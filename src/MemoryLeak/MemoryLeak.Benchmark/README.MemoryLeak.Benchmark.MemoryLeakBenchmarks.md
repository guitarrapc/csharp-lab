```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **780.2 ns** |   **273.5 ns** | **14.99 ns** |   **770.3 ns** |   **797.4 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   742.5 ns |   525.3 ns | 28.79 ns |   724.1 ns |   775.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   733.4 ns |   152.2 ns |  8.34 ns |   724.4 ns |   741.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   770.8 ns |   591.2 ns | 32.40 ns |   739.6 ns |   804.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   763.9 ns |   145.7 ns |  7.99 ns |   757.0 ns |   772.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,283.1 ns** | **1,413.3 ns** | **77.47 ns** | **2,229.0 ns** | **2,371.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,198.2 ns |   196.5 ns | 10.77 ns | 2,185.8 ns | 2,204.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,210.3 ns |   977.1 ns | 53.56 ns | 2,148.8 ns | 2,246.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,201.1 ns | 1,692.4 ns | 92.77 ns | 2,140.6 ns | 2,307.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,309.3 ns | 1,271.6 ns | 69.70 ns | 2,248.1 ns | 2,385.2 ns | 0.0343 | 0.0305 |   3.07 KB |
