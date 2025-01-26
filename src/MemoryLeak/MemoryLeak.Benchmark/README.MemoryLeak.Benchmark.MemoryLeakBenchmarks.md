```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **751.6 ns** |   **755.7 ns** |  **41.42 ns** |   **708.6 ns** |   **791.2 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   756.5 ns |   394.4 ns |  21.62 ns |   736.4 ns |   779.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   708.0 ns |   936.3 ns |  51.32 ns |   650.1 ns |   747.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   728.1 ns |   739.0 ns |  40.51 ns |   682.4 ns |   759.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   717.2 ns |   888.0 ns |  48.67 ns |   664.3 ns |   760.2 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,273.4 ns** |   **304.6 ns** |  **16.70 ns** | **2,259.4 ns** | **2,291.9 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,284.1 ns |   527.2 ns |  28.90 ns | 2,258.9 ns | 2,315.6 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,206.6 ns |   750.1 ns |  41.12 ns | 2,174.7 ns | 2,253.0 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,214.1 ns | 2,855.5 ns | 156.52 ns | 2,033.8 ns | 2,315.1 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,065.7 ns | 1,701.6 ns |  93.27 ns | 2,002.2 ns | 2,172.8 ns | 0.1869 | 0.1831 |   3.07 KB |
