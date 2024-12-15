```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **764.5 ns** |   **566.99 ns** | **31.08 ns** |   **728.7 ns** |   **784.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   717.8 ns |   316.68 ns | 17.36 ns |   698.9 ns |   733.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   700.0 ns |    30.53 ns |  1.67 ns |   698.2 ns |   701.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   743.7 ns |   426.12 ns | 23.36 ns |   729.1 ns |   770.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   722.7 ns |   935.96 ns | 51.30 ns |   682.8 ns |   780.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,203.1 ns** |   **961.85 ns** | **52.72 ns** | **2,142.6 ns** | **2,238.9 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,188.8 ns | 1,659.52 ns | 90.96 ns | 2,086.4 ns | 2,260.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,118.0 ns | 1,530.65 ns | 83.90 ns | 2,045.1 ns | 2,209.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,229.7 ns |   585.78 ns | 32.11 ns | 2,200.9 ns | 2,264.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,097.2 ns | 1,254.24 ns | 68.75 ns | 2,040.9 ns | 2,173.8 ns | 0.0343 | 0.0305 |   3.07 KB |
