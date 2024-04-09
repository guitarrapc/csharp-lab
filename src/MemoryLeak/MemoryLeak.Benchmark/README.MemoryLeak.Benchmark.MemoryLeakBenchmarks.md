```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error       | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|------------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **772.3 ns** |   **315.92 ns** |  **17.32 ns** |   **761.8 ns** |   **792.3 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   753.0 ns |    96.94 ns |   5.31 ns |   747.0 ns |   757.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   717.8 ns |   118.66 ns |   6.50 ns |   713.0 ns |   725.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   761.9 ns |   217.49 ns |  11.92 ns |   754.4 ns |   775.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   753.9 ns |   524.76 ns |  28.76 ns |   720.7 ns |   770.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,268.9 ns** | **1,787.93 ns** |  **98.00 ns** | **2,212.2 ns** | **2,382.0 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,258.7 ns |   758.84 ns |  41.59 ns | 2,216.1 ns | 2,299.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,210.5 ns | 1,074.67 ns |  58.91 ns | 2,149.2 ns | 2,266.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,308.1 ns | 2,567.16 ns | 140.71 ns | 2,168.1 ns | 2,449.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,176.5 ns |   979.77 ns |  53.70 ns | 2,114.6 ns | 2,209.5 ns | 0.0343 | 0.0305 |   3.07 KB |
