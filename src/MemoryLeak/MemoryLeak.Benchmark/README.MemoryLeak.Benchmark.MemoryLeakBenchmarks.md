```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **763.2 ns** |   **573.0 ns** |  **31.41 ns** |   **727.5 ns** |   **786.6 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   728.5 ns |   690.5 ns |  37.85 ns |   684.8 ns |   752.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   700.2 ns |   949.4 ns |  52.04 ns |   667.7 ns |   760.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   765.1 ns |   555.4 ns |  30.44 ns |   740.2 ns |   799.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   704.7 ns |   818.8 ns |  44.88 ns |   674.7 ns |   756.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,213.4 ns** | **2,500.3 ns** | **137.05 ns** | **2,096.5 ns** | **2,364.2 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,156.2 ns | 2,616.2 ns | 143.40 ns | 2,032.6 ns | 2,313.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,130.1 ns | 2,278.7 ns | 124.90 ns | 1,986.0 ns | 2,208.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,238.1 ns | 2,817.8 ns | 154.45 ns | 2,089.0 ns | 2,397.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,175.2 ns | 2,600.4 ns | 142.54 ns | 2,011.9 ns | 2,274.4 ns | 0.0343 | 0.0305 |   3.07 KB |
