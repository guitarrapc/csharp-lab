```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **746.3 ns** |   **417.4 ns** |  **22.88 ns** |   **723.5 ns** |   **769.2 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   734.4 ns |   147.1 ns |   8.07 ns |   727.7 ns |   743.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   714.9 ns |   454.9 ns |  24.94 ns |   698.0 ns |   743.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   765.0 ns |   354.0 ns |  19.40 ns |   752.7 ns |   787.4 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   728.3 ns |   697.1 ns |  38.21 ns |   692.0 ns |   768.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,324.6 ns** |   **925.3 ns** |  **50.72 ns** | **2,266.2 ns** | **2,357.7 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,215.4 ns |   941.4 ns |  51.60 ns | 2,179.3 ns | 2,274.5 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,126.6 ns | 2,167.9 ns | 118.83 ns | 2,036.7 ns | 2,261.3 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,253.0 ns | 1,152.2 ns |  63.16 ns | 2,187.2 ns | 2,313.1 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,140.8 ns |   993.0 ns |  54.43 ns | 2,079.8 ns | 2,184.4 ns | 0.0343 | 0.0305 |   3.07 KB |
