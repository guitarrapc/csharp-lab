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
| **AllocateStringStatic** | **1**      |   **761.9 ns** |   **415.8 ns** |  **22.79 ns** |   **741.4 ns** |   **786.4 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   742.1 ns |   274.9 ns |  15.07 ns |   732.6 ns |   759.5 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   706.5 ns |   988.4 ns |  54.18 ns |   646.7 ns |   752.4 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   699.8 ns |   632.8 ns |  34.69 ns |   675.8 ns |   739.6 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   752.6 ns |   170.9 ns |   9.37 ns |   743.7 ns |   762.3 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,164.4 ns** | **2,474.9 ns** | **135.66 ns** | **2,054.9 ns** | **2,316.2 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,250.5 ns |   331.8 ns |  18.19 ns | 2,229.6 ns | 2,262.2 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,110.7 ns | 2,200.4 ns | 120.61 ns | 1,972.4 ns | 2,194.0 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,272.9 ns | 1,068.0 ns |  58.54 ns | 2,215.7 ns | 2,332.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,189.5 ns | 2,116.2 ns | 116.00 ns | 2,055.8 ns | 2,263.3 ns | 0.1869 | 0.1831 |   3.07 KB |
