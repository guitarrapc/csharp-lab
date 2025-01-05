```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **737.8 ns** |   **832.1 ns** |  **45.61 ns** |   **687.8 ns** |   **777.0 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   720.6 ns |   799.4 ns |  43.82 ns |   672.2 ns |   757.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   706.4 ns |   943.1 ns |  51.69 ns |   648.0 ns |   746.1 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   728.4 ns |   722.8 ns |  39.62 ns |   686.1 ns |   764.6 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   714.2 ns |   943.1 ns |  51.69 ns |   656.9 ns |   757.2 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,212.5 ns** | **2,268.7 ns** | **124.35 ns** | **2,069.2 ns** | **2,292.3 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,235.1 ns |   356.6 ns |  19.54 ns | 2,214.7 ns | 2,253.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,025.3 ns | 2,248.1 ns | 123.23 ns | 1,949.9 ns | 2,167.5 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,238.8 ns |   492.9 ns |  27.02 ns | 2,217.3 ns | 2,269.1 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,181.7 ns |   408.8 ns |  22.41 ns | 2,162.6 ns | 2,206.3 ns | 0.1869 | 0.1831 |   3.07 KB |
