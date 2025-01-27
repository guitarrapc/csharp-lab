```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **776.2 ns** |   **297.44 ns** |  **16.30 ns** |   **762.1 ns** |   **794.1 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   745.4 ns |   279.91 ns |  15.34 ns |   734.7 ns |   762.9 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   705.9 ns |   841.84 ns |  46.14 ns |   653.3 ns |   739.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   700.3 ns |   545.17 ns |  29.88 ns |   675.8 ns |   733.6 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   712.2 ns |   820.40 ns |  44.97 ns |   662.4 ns |   749.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,192.4 ns** | **1,941.76 ns** | **106.43 ns** | **2,069.6 ns** | **2,258.1 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,020.4 ns |   242.53 ns |  13.29 ns | 2,006.4 ns | 2,032.9 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,170.0 ns |    61.69 ns |   3.38 ns | 2,167.5 ns | 2,173.9 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,090.7 ns | 1,910.53 ns | 104.72 ns | 2,020.8 ns | 2,211.1 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 1,973.2 ns |   346.55 ns |  19.00 ns | 1,961.3 ns | 1,995.1 ns | 0.1869 | 0.1831 |   3.07 KB |
