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
| **AllocateStringStatic** | **1**      |   **770.6 ns** |   **174.8 ns** |   **9.58 ns** |   **761.0 ns** |   **780.1 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   754.5 ns |   391.0 ns |  21.43 ns |   733.8 ns |   776.6 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   693.0 ns |   652.0 ns |  35.74 ns |   652.6 ns |   720.6 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   722.0 ns |   866.5 ns |  47.50 ns |   669.6 ns |   762.2 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   703.1 ns |   920.1 ns |  50.43 ns |   646.8 ns |   744.1 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,203.1 ns** | **2,713.8 ns** | **148.75 ns** | **2,031.7 ns** | **2,298.8 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,011.8 ns |   335.0 ns |  18.36 ns | 1,992.5 ns | 2,029.0 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 1,938.5 ns |   283.2 ns |  15.52 ns | 1,921.8 ns | 1,952.4 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,017.6 ns |   293.8 ns |  16.10 ns | 1,999.5 ns | 2,030.4 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 1,981.9 ns |   163.6 ns |   8.97 ns | 1,976.4 ns | 1,992.3 ns | 0.1869 | 0.1831 |   3.07 KB |
