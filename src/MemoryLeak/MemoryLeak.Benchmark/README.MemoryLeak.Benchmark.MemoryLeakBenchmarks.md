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
| **AllocateStringStatic** | **1**      |   **775.6 ns** |   **270.7 ns** |  **14.84 ns** |   **761.7 ns** |   **791.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   705.9 ns |   536.9 ns |  29.43 ns |   687.1 ns |   739.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   721.4 ns |   130.9 ns |   7.18 ns |   714.9 ns |   729.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   734.7 ns |   495.6 ns |  27.17 ns |   703.5 ns |   753.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   751.5 ns |   152.9 ns |   8.38 ns |   744.7 ns |   760.8 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,213.4 ns** | **2,028.9 ns** | **111.21 ns** | **2,124.7 ns** | **2,338.2 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,213.2 ns | 2,656.6 ns | 145.62 ns | 2,045.1 ns | 2,299.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,148.0 ns | 2,280.8 ns | 125.02 ns | 2,004.2 ns | 2,230.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,303.9 ns | 2,133.9 ns | 116.96 ns | 2,181.1 ns | 2,414.0 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,107.5 ns | 2,255.0 ns | 123.61 ns | 2,022.2 ns | 2,249.3 ns | 0.0343 | 0.0305 |   3.07 KB |
