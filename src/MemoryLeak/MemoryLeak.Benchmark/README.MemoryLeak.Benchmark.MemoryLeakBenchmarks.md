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
| **AllocateStringStatic** | **1**      |   **758.6 ns** |   **296.7 ns** |  **16.26 ns** |   **745.7 ns** |   **776.9 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   731.5 ns |   839.0 ns |  45.99 ns |   685.1 ns |   777.0 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   703.5 ns |   903.6 ns |  49.53 ns |   647.8 ns |   742.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   726.4 ns |   895.5 ns |  49.08 ns |   670.8 ns |   763.7 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   710.9 ns |   947.8 ns |  51.95 ns |   652.0 ns |   749.9 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,275.2 ns** |   **179.8 ns** |   **9.85 ns** | **2,268.2 ns** | **2,286.5 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,228.4 ns |   320.0 ns |  17.54 ns | 2,215.3 ns | 2,248.3 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,135.8 ns | 2,660.9 ns | 145.85 ns | 1,970.7 ns | 2,247.1 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,044.7 ns |   340.8 ns |  18.68 ns | 2,027.5 ns | 2,064.6 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,140.0 ns | 2,486.1 ns | 136.27 ns | 2,054.7 ns | 2,297.1 ns | 0.1869 | 0.1831 |   3.07 KB |
