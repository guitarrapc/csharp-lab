```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **751.2 ns** |    **44.23 ns** |  **2.42 ns** |   **749.3 ns** |   **753.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   722.7 ns |   283.18 ns | 15.52 ns |   704.9 ns |   733.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   693.9 ns |   530.41 ns | 29.07 ns |   671.5 ns |   726.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   713.1 ns |   699.55 ns | 38.34 ns |   688.8 ns |   757.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   714.0 ns |   531.37 ns | 29.13 ns |   684.6 ns |   742.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,229.5 ns** | **1,228.02 ns** | **67.31 ns** | **2,154.8 ns** | **2,285.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,203.4 ns |   468.72 ns | 25.69 ns | 2,180.6 ns | 2,231.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,051.2 ns |   596.90 ns | 32.72 ns | 2,025.2 ns | 2,087.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,177.3 ns | 1,077.58 ns | 59.07 ns | 2,112.4 ns | 2,227.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,125.7 ns | 1,336.05 ns | 73.23 ns | 2,053.6 ns | 2,200.0 ns | 0.0343 | 0.0305 |   3.07 KB |
