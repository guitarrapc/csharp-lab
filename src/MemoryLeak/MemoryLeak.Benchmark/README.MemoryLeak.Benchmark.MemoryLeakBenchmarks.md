```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **746.0 ns** |   **441.5 ns** | **24.20 ns** |   **731.3 ns** |   **774.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   733.4 ns |   299.7 ns | 16.43 ns |   723.8 ns |   752.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   713.7 ns |   261.0 ns | 14.31 ns |   697.9 ns |   725.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   727.2 ns |   467.7 ns | 25.64 ns |   711.1 ns |   756.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   725.5 ns |   304.2 ns | 16.68 ns |   706.5 ns |   737.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,263.4 ns** | **1,185.9 ns** | **65.00 ns** | **2,198.4 ns** | **2,328.4 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,237.7 ns |   801.0 ns | 43.91 ns | 2,203.8 ns | 2,287.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,101.3 ns | 1,409.9 ns | 77.28 ns | 2,034.6 ns | 2,186.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,211.2 ns |   764.1 ns | 41.89 ns | 2,163.0 ns | 2,238.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,161.3 ns | 1,090.7 ns | 59.79 ns | 2,097.0 ns | 2,215.2 ns | 0.0343 | 0.0305 |   3.07 KB |
