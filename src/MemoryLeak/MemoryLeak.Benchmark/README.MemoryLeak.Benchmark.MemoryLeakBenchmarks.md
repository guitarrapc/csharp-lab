```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **732.4 ns** |   **557.1 ns** | **30.54 ns** |   **712.3 ns** |   **767.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   712.5 ns |   160.8 ns |  8.82 ns |   704.5 ns |   722.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   719.6 ns |   473.4 ns | 25.95 ns |   703.4 ns |   749.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   727.7 ns |   585.3 ns | 32.08 ns |   701.9 ns |   763.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   717.2 ns |   196.8 ns | 10.79 ns |   705.8 ns |   727.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,218.9 ns** |   **927.0 ns** | **50.81 ns** | **2,160.6 ns** | **2,253.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,152.4 ns |   510.7 ns | 27.99 ns | 2,123.1 ns | 2,178.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,119.1 ns |   646.2 ns | 35.42 ns | 2,083.4 ns | 2,154.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,172.5 ns | 1,105.3 ns | 60.58 ns | 2,105.1 ns | 2,222.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,128.2 ns |   894.0 ns | 49.01 ns | 2,075.2 ns | 2,171.9 ns | 0.0343 | 0.0305 |   3.07 KB |
