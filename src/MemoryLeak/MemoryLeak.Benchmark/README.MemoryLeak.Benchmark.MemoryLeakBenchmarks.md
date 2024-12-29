```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **750.7 ns** |   **195.85 ns** | **10.74 ns** |   **739.0 ns** |   **760.1 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   736.4 ns |   252.17 ns | 13.82 ns |   725.5 ns |   752.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   716.5 ns |   171.01 ns |  9.37 ns |   705.9 ns |   723.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   733.9 ns |    43.47 ns |  2.38 ns |   732.0 ns |   736.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   701.5 ns |   426.29 ns | 23.37 ns |   686.4 ns |   728.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,204.2 ns** |   **755.90 ns** | **41.43 ns** | **2,158.0 ns** | **2,238.2 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,112.8 ns | 1,723.70 ns | 94.48 ns | 2,056.4 ns | 2,221.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,016.8 ns | 1,144.68 ns | 62.74 ns | 1,976.0 ns | 2,089.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,175.6 ns |   745.62 ns | 40.87 ns | 2,129.4 ns | 2,207.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,098.1 ns |   906.57 ns | 49.69 ns | 2,043.6 ns | 2,140.9 ns | 0.0343 | 0.0305 |   3.07 KB |
