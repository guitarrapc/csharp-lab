```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Number | Mean       | Error      | StdDev    | Min        | Max        | Gen0   | Gen1   | Allocated |
|--------------------- |------- |-----------:|-----------:|----------:|-----------:|-----------:|-------:|-------:|----------:|
| **AllocateStringStatic** | **1**      |   **744.1 ns** |   **213.4 ns** |  **11.70 ns** |   **732.1 ns** |   **755.5 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   714.2 ns |   506.1 ns |  27.74 ns |   697.7 ns |   746.2 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   712.7 ns |   207.4 ns |  11.37 ns |   700.9 ns |   723.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   734.8 ns |   279.5 ns |  15.32 ns |   717.9 ns |   747.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   724.7 ns |   512.3 ns |  28.08 ns |   705.3 ns |   756.9 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **10**     | **7,673.6 ns** | **4,083.6 ns** | **223.84 ns** | **7,479.4 ns** | **7,918.4 ns** | **0.1221** | **0.1144** |  **10.23 KB** |
| AllocateString       | 10     | 7,241.0 ns | 3,123.6 ns | 171.21 ns | 7,095.8 ns | 7,429.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateLoH          | 10     | 7,083.9 ns | 3,568.0 ns | 195.57 ns | 6,948.4 ns | 7,308.1 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArray        | 10     | 7,362.6 ns | 2,579.6 ns | 141.40 ns | 7,276.2 ns | 7,525.8 ns | 0.1221 | 0.1144 |  10.23 KB |
| AllocateArrayPool    | 10     | 7,145.6 ns | 4,698.6 ns | 257.55 ns | 6,886.6 ns | 7,401.7 ns | 0.1221 | 0.1144 |  10.23 KB |
