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
| **AllocateStringStatic** | **1**      |   **771.2 ns** |   **528.8 ns** |  **28.98 ns** |   **738.5 ns** |   **793.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   736.5 ns |   594.9 ns |  32.61 ns |   714.3 ns |   774.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   760.9 ns |   716.5 ns |  39.28 ns |   717.0 ns |   792.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   784.2 ns |   796.9 ns |  43.68 ns |   733.9 ns |   812.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   748.9 ns |   820.0 ns |  44.94 ns |   699.8 ns |   788.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,333.3 ns** | **1,827.8 ns** | **100.19 ns** | **2,219.4 ns** | **2,407.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,240.1 ns | 2,778.8 ns | 152.31 ns | 2,064.3 ns | 2,331.9 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,190.9 ns | 1,266.3 ns |  69.41 ns | 2,115.0 ns | 2,251.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,153.3 ns | 1,362.3 ns |  74.67 ns | 2,108.9 ns | 2,239.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,318.8 ns |   830.8 ns |  45.54 ns | 2,270.3 ns | 2,360.6 ns | 0.0343 | 0.0305 |   3.07 KB |
