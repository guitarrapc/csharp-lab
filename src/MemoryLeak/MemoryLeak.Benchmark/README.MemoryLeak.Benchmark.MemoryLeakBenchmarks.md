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
| **AllocateStringStatic** | **1**      |   **761.5 ns** |   **363.5 ns** |  **19.92 ns** |   **745.1 ns** |   **783.7 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   747.1 ns |   467.6 ns |  25.63 ns |   729.2 ns |   776.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   703.8 ns |   281.6 ns |  15.43 ns |   688.4 ns |   719.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   748.4 ns |   333.0 ns |  18.25 ns |   731.2 ns |   767.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   771.7 ns |   116.5 ns |   6.39 ns |   764.3 ns |   775.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,288.9 ns** | **1,717.2 ns** |  **94.13 ns** | **2,181.6 ns** | **2,357.5 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,244.5 ns |   489.0 ns |  26.80 ns | 2,220.7 ns | 2,273.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,125.1 ns | 1,971.5 ns | 108.07 ns | 2,025.4 ns | 2,240.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,182.7 ns |   614.7 ns |  33.70 ns | 2,155.6 ns | 2,220.4 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,205.4 ns | 1,284.3 ns |  70.40 ns | 2,151.4 ns | 2,285.0 ns | 0.0343 | 0.0305 |   3.07 KB |
