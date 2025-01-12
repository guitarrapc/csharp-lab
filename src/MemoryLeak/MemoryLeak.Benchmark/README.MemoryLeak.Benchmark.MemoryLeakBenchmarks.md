```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error    | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|---------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **807.7 ns** | **626.6 ns** | **34.35 ns** |   **781.1 ns** |   **846.4 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   750.2 ns | 882.2 ns | 48.36 ns |   695.9 ns |   788.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   724.1 ns | 779.7 ns | 42.74 ns |   677.1 ns |   760.6 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   728.2 ns | 467.8 ns | 25.64 ns |   709.9 ns |   757.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   769.5 ns | 926.4 ns | 50.78 ns |   731.1 ns |   827.0 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,348.0 ns** | **487.2 ns** | **26.70 ns** | **2,320.5 ns** | **2,373.8 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,079.1 ns | 221.8 ns | 12.16 ns | 2,065.2 ns | 2,088.0 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,281.6 ns | 110.0 ns |  6.03 ns | 2,275.4 ns | 2,287.4 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,094.5 ns | 134.3 ns |  7.36 ns | 2,086.6 ns | 2,101.2 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,272.9 ns | 409.1 ns | 22.43 ns | 2,251.9 ns | 2,296.6 ns | 0.1869 | 0.1831 |   3.07 KB |
