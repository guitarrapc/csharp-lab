```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **745.8 ns** |   **374.3 ns** |  **20.52 ns** |   **733.7 ns** |   **769.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   712.9 ns |   292.0 ns |  16.01 ns |   694.5 ns |   723.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   680.6 ns |   129.7 ns |   7.11 ns |   674.8 ns |   688.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   742.6 ns |   441.6 ns |  24.21 ns |   721.9 ns |   769.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   717.7 ns |   526.8 ns |  28.87 ns |   686.1 ns |   742.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,198.0 ns** | **2,277.3 ns** | **124.83 ns** | **2,080.8 ns** | **2,329.3 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,203.2 ns |   852.4 ns |  46.72 ns | 2,149.6 ns | 2,235.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,120.6 ns | 1,124.9 ns |  61.66 ns | 2,059.2 ns | 2,182.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,214.4 ns | 1,233.6 ns |  67.62 ns | 2,136.3 ns | 2,254.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,092.2 ns | 1,516.6 ns |  83.13 ns | 2,018.3 ns | 2,182.2 ns | 0.0343 | 0.0305 |   3.07 KB |
