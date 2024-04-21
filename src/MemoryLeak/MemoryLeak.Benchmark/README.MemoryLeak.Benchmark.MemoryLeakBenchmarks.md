```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **779.5 ns** |   **149.0 ns** |  **8.17 ns** |   **770.5 ns** |   **786.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   758.1 ns |   240.5 ns | 13.18 ns |   746.0 ns |   772.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   713.4 ns |   158.7 ns |  8.70 ns |   703.3 ns |   719.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   754.4 ns |   190.3 ns | 10.43 ns |   747.4 ns |   766.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   726.2 ns |   580.5 ns | 31.82 ns |   707.0 ns |   763.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,205.3 ns** |   **664.1 ns** | **36.40 ns** | **2,163.8 ns** | **2,231.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,240.8 ns |   220.1 ns | 12.06 ns | 2,232.2 ns | 2,254.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,157.2 ns | 1,500.4 ns | 82.24 ns | 2,065.9 ns | 2,225.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,159.8 ns | 1,171.0 ns | 64.18 ns | 2,097.1 ns | 2,225.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,134.5 ns | 1,134.9 ns | 62.21 ns | 2,062.7 ns | 2,170.7 ns | 0.0343 | 0.0305 |   3.07 KB |
