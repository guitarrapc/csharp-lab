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
| **AllocateStringStatic** | **1**      |   **754.1 ns** | **1,058.0 ns** |  **57.99 ns** |   **692.5 ns** |   **807.6 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   722.8 ns |   777.1 ns |  42.59 ns |   676.1 ns |   759.6 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   697.4 ns |   917.6 ns |  50.30 ns |   642.0 ns |   740.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   720.4 ns |   626.1 ns |  34.32 ns |   682.1 ns |   748.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   702.7 ns |   812.7 ns |  44.54 ns |   652.9 ns |   738.7 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,253.8 ns** |   **294.5 ns** |  **16.14 ns** | **2,240.2 ns** | **2,271.6 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,021.3 ns |   352.7 ns |  19.33 ns | 2,006.8 ns | 2,043.3 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,226.5 ns | 1,335.1 ns |  73.18 ns | 2,158.6 ns | 2,304.0 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,269.5 ns |   439.2 ns |  24.07 ns | 2,246.4 ns | 2,294.4 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,143.9 ns | 2,759.6 ns | 151.26 ns | 1,971.4 ns | 2,254.0 ns | 0.1869 | 0.1831 |   3.07 KB |
