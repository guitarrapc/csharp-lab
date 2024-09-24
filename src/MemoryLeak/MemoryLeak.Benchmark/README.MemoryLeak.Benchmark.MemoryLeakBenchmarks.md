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
| **AllocateStringStatic** | **1**      |   **776.1 ns** |   **311.2 ns** |  **17.06 ns** |   **762.4 ns** |   **795.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   725.6 ns |   330.9 ns |  18.14 ns |   705.1 ns |   739.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   703.5 ns |   580.0 ns |  31.79 ns |   668.4 ns |   730.3 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   738.0 ns |   841.3 ns |  46.11 ns |   690.0 ns |   781.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   700.9 ns |   370.3 ns |  20.30 ns |   677.8 ns |   715.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,249.5 ns** | **1,340.6 ns** |  **73.48 ns** | **2,167.7 ns** | **2,310.0 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,171.5 ns | 2,613.1 ns | 143.23 ns | 2,006.2 ns | 2,258.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,054.7 ns | 1,702.8 ns |  93.34 ns | 1,973.3 ns | 2,156.6 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,206.6 ns | 1,677.4 ns |  91.95 ns | 2,101.0 ns | 2,269.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,133.4 ns | 2,322.9 ns | 127.32 ns | 1,986.6 ns | 2,213.4 ns | 0.0343 | 0.0305 |   3.07 KB |
