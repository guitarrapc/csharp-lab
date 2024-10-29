```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **748.3 ns** |   **395.6 ns** | **21.69 ns** |   **723.8 ns** |   **765.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   732.7 ns |   155.3 ns |  8.51 ns |   724.4 ns |   741.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   723.3 ns |   368.0 ns | 20.17 ns |   711.3 ns |   746.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   750.5 ns |   290.9 ns | 15.95 ns |   736.4 ns |   767.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   740.1 ns |   139.3 ns |  7.64 ns |   733.5 ns |   748.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,283.6 ns** | **1,481.2 ns** | **81.19 ns** | **2,191.3 ns** | **2,344.1 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,098.0 ns | 1,569.6 ns | 86.03 ns | 2,041.9 ns | 2,197.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,095.7 ns |   798.8 ns | 43.79 ns | 2,055.3 ns | 2,142.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,193.5 ns |   884.8 ns | 48.50 ns | 2,138.2 ns | 2,228.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,141.0 ns | 1,598.7 ns | 87.63 ns | 2,045.9 ns | 2,218.4 ns | 0.0343 | 0.0305 |   3.07 KB |
