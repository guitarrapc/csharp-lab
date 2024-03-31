```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **770.8 ns** |   **442.6 ns** |  **24.26 ns** |   **745.3 ns** |   **793.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   760.2 ns |   348.8 ns |  19.12 ns |   748.4 ns |   782.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   732.7 ns |   233.3 ns |  12.79 ns |   721.4 ns |   746.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   741.1 ns |   475.7 ns |  26.08 ns |   711.1 ns |   758.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   737.2 ns |   614.3 ns |  33.67 ns |   703.1 ns |   770.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,316.1 ns** | **2,030.5 ns** | **111.30 ns** | **2,187.6 ns** | **2,383.6 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,167.6 ns | 1,462.7 ns |  80.17 ns | 2,095.6 ns | 2,254.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,212.2 ns | 1,477.5 ns |  80.99 ns | 2,146.6 ns | 2,302.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,158.2 ns | 2,137.1 ns | 117.14 ns | 2,087.2 ns | 2,293.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,263.5 ns |   890.8 ns |  48.83 ns | 2,207.6 ns | 2,298.0 ns | 0.0343 | 0.0305 |   3.07 KB |
