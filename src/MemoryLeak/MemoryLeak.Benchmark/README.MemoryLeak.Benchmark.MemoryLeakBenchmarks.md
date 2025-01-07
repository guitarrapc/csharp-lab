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
| **AllocateStringStatic** | **1**      |   **767.3 ns** |   **379.4 ns** |  **20.79 ns** |   **747.6 ns** |   **789.0 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   723.0 ns |   773.9 ns |  42.42 ns |   676.9 ns |   760.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   702.7 ns |   628.0 ns |  34.42 ns |   664.5 ns |   731.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   746.4 ns |   322.6 ns |  17.68 ns |   733.3 ns |   766.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   735.1 ns |   231.0 ns |  12.66 ns |   724.5 ns |   749.1 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,311.5 ns** |   **429.8 ns** |  **23.56 ns** | **2,291.5 ns** | **2,337.5 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,018.8 ns |   307.8 ns |  16.87 ns | 2,007.3 ns | 2,038.2 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 1,955.6 ns |   431.5 ns |  23.65 ns | 1,935.1 ns | 1,981.4 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,191.1 ns | 2,728.6 ns | 149.56 ns | 2,025.4 ns | 2,316.0 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,192.6 ns |   615.4 ns |  33.73 ns | 2,168.1 ns | 2,231.1 ns | 0.1869 | 0.1831 |   3.07 KB |
