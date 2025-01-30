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
| **AllocateStringStatic** | **1**      |   **766.5 ns** |   **322.5 ns** |  **17.68 ns** |   **755.6 ns** |   **786.9 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   696.1 ns |   739.2 ns |  40.52 ns |   667.0 ns |   742.4 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   701.2 ns |   834.2 ns |  45.72 ns |   650.7 ns |   739.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   719.6 ns |   633.2 ns |  34.71 ns |   680.8 ns |   747.8 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   705.3 ns |   806.5 ns |  44.21 ns |   656.9 ns |   743.6 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,277.7 ns** |   **503.4 ns** |  **27.59 ns** | **2,255.7 ns** | **2,308.6 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,054.7 ns |   234.4 ns |  12.85 ns | 2,039.9 ns | 2,062.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,084.7 ns | 2,157.3 ns | 118.25 ns | 2,006.9 ns | 2,220.7 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,050.0 ns |   215.0 ns |  11.78 ns | 2,040.1 ns | 2,063.1 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 1,973.8 ns |   259.8 ns |  14.24 ns | 1,962.3 ns | 1,989.7 ns | 0.1869 | 0.1831 |   3.07 KB |
