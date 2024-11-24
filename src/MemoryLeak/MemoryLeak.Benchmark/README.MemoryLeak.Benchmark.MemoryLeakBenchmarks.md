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
| **AllocateStringStatic** | **1**      |   **770.9 ns** |   **617.61 ns** | **33.85 ns** |   **749.7 ns** |   **809.9 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   750.1 ns |   107.17 ns |  5.87 ns |   744.0 ns |   755.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   743.3 ns |   160.10 ns |  8.78 ns |   735.0 ns |   752.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   751.5 ns |    24.37 ns |  1.34 ns |   750.4 ns |   753.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   740.8 ns |   662.68 ns | 36.32 ns |   706.5 ns |   778.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,265.3 ns** | **1,735.95 ns** | **95.15 ns** | **2,159.4 ns** | **2,343.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,261.8 ns | 1,820.20 ns | 99.77 ns | 2,151.7 ns | 2,346.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,112.3 ns | 1,613.54 ns | 88.44 ns | 2,047.4 ns | 2,213.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,311.4 ns |   869.11 ns | 47.64 ns | 2,269.3 ns | 2,363.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,180.0 ns | 1,693.44 ns | 92.82 ns | 2,076.0 ns | 2,254.6 ns | 0.0343 | 0.0305 |   3.07 KB |
