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
| **AllocateStringStatic** | **1**      |   **780.0 ns** |   **133.9 ns** |   **7.34 ns** |   **771.7 ns** |   **785.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   739.4 ns |   811.2 ns |  44.47 ns |   689.8 ns |   775.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   700.2 ns |   417.2 ns |  22.87 ns |   675.2 ns |   720.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   738.8 ns |   813.4 ns |  44.58 ns |   687.3 ns |   765.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   708.5 ns |   952.0 ns |  52.18 ns |   675.5 ns |   768.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,217.5 ns** | **1,727.3 ns** |  **94.68 ns** | **2,113.9 ns** | **2,299.6 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,129.8 ns | 2,067.4 ns | 113.32 ns | 2,053.7 ns | 2,260.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,138.1 ns | 2,065.5 ns | 113.22 ns | 2,009.6 ns | 2,223.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,193.8 ns | 2,396.9 ns | 131.38 ns | 2,045.9 ns | 2,297.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,162.4 ns | 1,622.7 ns |  88.94 ns | 2,063.0 ns | 2,234.4 ns | 0.0343 | 0.0305 |   3.07 KB |
