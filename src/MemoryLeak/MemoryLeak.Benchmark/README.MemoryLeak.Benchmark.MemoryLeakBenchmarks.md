```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **812.4 ns** |   **604.6 ns** | **33.14 ns** |   **792.0 ns** |   **850.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   763.0 ns |   387.6 ns | 21.25 ns |   744.5 ns |   786.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   777.9 ns |   623.7 ns | 34.19 ns |   746.9 ns |   814.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   787.5 ns |   249.6 ns | 13.68 ns |   774.6 ns |   801.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   771.7 ns |   464.4 ns | 25.46 ns |   742.4 ns |   788.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,280.6 ns** | **1,232.6 ns** | **67.57 ns** | **2,232.7 ns** | **2,357.8 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,260.1 ns | 1,477.5 ns | 80.99 ns | 2,182.5 ns | 2,344.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,198.5 ns |   995.7 ns | 54.58 ns | 2,156.6 ns | 2,260.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,257.8 ns | 1,378.8 ns | 75.58 ns | 2,211.5 ns | 2,345.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,225.1 ns | 1,230.7 ns | 67.46 ns | 2,148.3 ns | 2,274.8 ns | 0.0343 | 0.0305 |   3.07 KB |
