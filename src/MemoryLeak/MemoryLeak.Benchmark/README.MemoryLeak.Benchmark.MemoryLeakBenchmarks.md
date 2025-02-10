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
| **AllocateStringStatic** | **1**      |   **793.1 ns** |   **308.0 ns** |  **16.88 ns** |   **776.2 ns** |   **810.0 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   739.1 ns |   849.6 ns |  46.57 ns |   687.9 ns |   778.9 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   695.7 ns |   567.4 ns |  31.10 ns |   669.5 ns |   730.1 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   770.0 ns |   314.5 ns |  17.24 ns |   754.1 ns |   788.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   724.4 ns |   880.9 ns |  48.29 ns |   671.8 ns |   766.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,316.7 ns** |   **304.3 ns** |  **16.68 ns** | **2,300.4 ns** | **2,333.8 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,187.2 ns | 2,095.5 ns | 114.86 ns | 2,054.6 ns | 2,254.2 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,198.7 ns |   282.4 ns |  15.48 ns | 2,186.4 ns | 2,216.1 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,313.3 ns | 1,090.4 ns |  59.77 ns | 2,276.8 ns | 2,382.3 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,219.1 ns |   237.6 ns |  13.02 ns | 2,207.4 ns | 2,233.1 ns | 0.1869 | 0.1831 |   3.07 KB |
