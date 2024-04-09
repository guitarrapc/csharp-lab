```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **760.0 ns** |   **305.4 ns** | **16.74 ns** |   **741.3 ns** |   **773.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   711.4 ns |   725.3 ns | 39.75 ns |   687.0 ns |   757.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   704.8 ns |   330.7 ns | 18.13 ns |   692.3 ns |   725.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   723.8 ns |   307.8 ns | 16.87 ns |   707.3 ns |   741.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   717.8 ns |   236.6 ns | 12.97 ns |   703.5 ns |   728.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,275.6 ns** | **1,232.8 ns** | **67.58 ns** | **2,204.9 ns** | **2,339.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,104.9 ns | 1,121.8 ns | 61.49 ns | 2,053.0 ns | 2,172.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,103.1 ns | 1,062.6 ns | 58.24 ns | 2,042.7 ns | 2,158.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,229.7 ns | 1,366.5 ns | 74.90 ns | 2,144.3 ns | 2,284.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,156.3 ns |   802.7 ns | 44.00 ns | 2,106.7 ns | 2,190.5 ns | 0.0343 | 0.0305 |   3.07 KB |
