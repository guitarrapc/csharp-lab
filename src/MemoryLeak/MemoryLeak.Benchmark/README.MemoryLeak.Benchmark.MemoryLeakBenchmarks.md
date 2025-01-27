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
| **AllocateStringStatic** | **1**      |   **763.1 ns** |   **453.7 ns** |  **24.87 ns** |   **740.4 ns** |   **789.7 ns** | **0.0620** | **0.0610** |   **1.02 KB** |
| AllocateString       | 1      |   720.3 ns |   648.1 ns |  35.52 ns |   680.7 ns |   749.2 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateLoH          | 1      |   703.4 ns |   928.7 ns |  50.91 ns |   646.3 ns |   743.9 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArray        | 1      |   728.8 ns |   963.5 ns |  52.81 ns |   669.2 ns |   769.9 ns | 0.0620 | 0.0610 |   1.02 KB |
| AllocateArrayPool    | 1      |   733.3 ns |   230.8 ns |  12.65 ns |   719.9 ns |   745.0 ns | 0.0620 | 0.0610 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,179.9 ns** | **2,045.0 ns** | **112.09 ns** | **2,050.5 ns** | **2,247.3 ns** | **0.1869** | **0.1831** |   **3.07 KB** |
| AllocateString       | 3      | 2,106.2 ns | 2,704.5 ns | 148.24 ns | 2,004.5 ns | 2,276.3 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateLoH          | 3      | 2,153.8 ns |   239.5 ns |  13.13 ns | 2,141.2 ns | 2,167.4 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArray        | 3      | 2,248.1 ns |   229.8 ns |  12.59 ns | 2,235.2 ns | 2,260.4 ns | 0.1869 | 0.1831 |   3.07 KB |
| AllocateArrayPool    | 3      | 1,978.4 ns |   141.9 ns |   7.78 ns | 1,972.9 ns | 1,987.3 ns | 0.1869 | 0.1831 |   3.07 KB |
