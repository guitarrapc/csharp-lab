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
| **AllocateStringStatic** | **1**      |   **762.4 ns** |   **457.8 ns** |  **25.09 ns** |   **739.2 ns** |   **789.0 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   688.9 ns |   583.7 ns |  32.00 ns |   666.0 ns |   725.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   705.5 ns |   952.3 ns |  52.20 ns |   649.0 ns |   752.0 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   745.3 ns |   276.5 ns |  15.16 ns |   734.9 ns |   762.7 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   708.2 ns |   986.9 ns |  54.10 ns |   648.5 ns |   753.9 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,271.7 ns** |   **309.0 ns** |  **16.94 ns** | **2,261.8 ns** | **2,291.2 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,221.5 ns |   501.8 ns |  27.51 ns | 2,204.6 ns | 2,253.3 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,172.6 ns |   337.6 ns |  18.50 ns | 2,159.2 ns | 2,193.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,129.8 ns | 2,599.1 ns | 142.46 ns | 2,047.4 ns | 2,294.3 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,115.0 ns | 2,757.1 ns | 151.12 ns | 1,941.2 ns | 2,215.2 ns | 0.1869 | 0.1831 |   3.07 KB |
