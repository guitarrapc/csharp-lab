```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **758.4 ns** |   **616.8 ns** | **33.81 ns** |   **721.7 ns** |   **788.2 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   713.8 ns |   629.8 ns | 34.52 ns |   687.6 ns |   752.9 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   725.6 ns |   270.9 ns | 14.85 ns |   714.3 ns |   742.4 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   752.5 ns |   276.9 ns | 15.18 ns |   740.8 ns |   769.7 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   715.7 ns |   914.8 ns | 50.14 ns |   658.7 ns |   753.1 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,301.6 ns** | **1,423.6 ns** | **78.03 ns** | **2,253.5 ns** | **2,391.6 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,040.7 ns |   346.3 ns | 18.98 ns | 2,022.1 ns | 2,060.1 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 1,948.6 ns |   254.2 ns | 13.93 ns | 1,939.5 ns | 1,964.6 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,238.0 ns |   495.8 ns | 27.18 ns | 2,207.5 ns | 2,259.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 1,980.5 ns |   546.3 ns | 29.94 ns | 1,950.0 ns | 2,009.9 ns | 0.1869 | 0.1831 |   3.07 KB |
