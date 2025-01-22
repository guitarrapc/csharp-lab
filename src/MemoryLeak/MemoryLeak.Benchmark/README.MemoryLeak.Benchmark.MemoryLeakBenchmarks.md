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
| **AllocateStringStatic** | **1**      |   **736.8 ns** |   **566.1 ns** |  **31.03 ns** |   **703.5 ns** |   **764.9 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   729.0 ns |   585.7 ns |  32.11 ns |   693.7 ns |   756.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   734.8 ns |   306.9 ns |  16.82 ns |   715.8 ns |   747.7 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   733.1 ns |   898.7 ns |  49.26 ns |   677.0 ns |   769.2 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   703.1 ns |   860.4 ns |  47.16 ns |   649.8 ns |   739.4 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,196.3 ns** | **2,718.6 ns** | **149.02 ns** | **2,024.5 ns** | **2,290.8 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,010.7 ns |   366.4 ns |  20.08 ns | 1,992.1 ns | 2,032.0 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 1,948.4 ns |   294.4 ns |  16.14 ns | 1,935.2 ns | 1,966.4 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,224.1 ns |   391.9 ns |  21.48 ns | 2,203.6 ns | 2,246.5 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 1,963.0 ns |   154.3 ns |   8.46 ns | 1,955.1 ns | 1,971.9 ns | 0.1869 | 0.1831 |   3.07 KB |
