```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **758.3 ns** |   **872.1 ns** |  **47.80 ns** |   **703.1 ns** |   **788.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   706.2 ns | 1,015.5 ns |  55.67 ns |   669.8 ns |   770.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   729.2 ns |   106.3 ns |   5.83 ns |   722.5 ns |   733.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   729.8 ns |   380.2 ns |  20.84 ns |   707.4 ns |   748.7 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   735.2 ns |   953.9 ns |  52.28 ns |   678.0 ns |   780.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,175.8 ns** | **2,115.4 ns** | **115.95 ns** | **2,102.1 ns** | **2,309.4 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,097.6 ns | 1,865.7 ns | 102.26 ns | 2,023.8 ns | 2,214.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,048.3 ns | 2,356.0 ns | 129.14 ns | 1,940.0 ns | 2,191.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,228.4 ns | 1,976.9 ns | 108.36 ns | 2,105.7 ns | 2,311.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,105.0 ns | 2,024.2 ns | 110.95 ns | 2,018.1 ns | 2,230.0 ns | 0.0343 | 0.0305 |   3.07 KB |
