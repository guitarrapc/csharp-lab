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
| **AllocateStringStatic** | **1**      |   **748.6 ns** |   **255.1 ns** |  **13.98 ns** |   **732.7 ns** |   **759.0 ns** | **0.0124** | **0.0114** |   **1.02 KB** |
| AllocateString       | 1      |   723.1 ns |   202.9 ns |  11.12 ns |   710.4 ns |   731.1 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateLoH          | 1      |   706.6 ns |   368.6 ns |  20.20 ns |   684.1 ns |   723.0 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArray        | 1      |   742.8 ns |   631.6 ns |  34.62 ns |   702.8 ns |   763.6 ns | 0.0124 | 0.0114 |   1.02 KB |
| AllocateArrayPool    | 1      |   714.9 ns |   600.0 ns |  32.89 ns |   691.9 ns |   752.5 ns | 0.0124 | 0.0114 |   1.02 KB |
| **AllocateStringStatic** | **3**      | **2,330.0 ns** | **1,856.5 ns** | **101.76 ns** | **2,257.6 ns** | **2,446.4 ns** | **0.0343** | **0.0305** |   **3.07 KB** |
| AllocateString       | 3      | 2,129.3 ns |   795.4 ns |  43.60 ns | 2,085.6 ns | 2,172.8 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateLoH          | 3      | 2,102.1 ns |   800.2 ns |  43.86 ns | 2,051.9 ns | 2,133.2 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArray        | 3      | 2,224.0 ns | 1,041.4 ns |  57.08 ns | 2,175.0 ns | 2,286.7 ns | 0.0343 | 0.0305 |   3.07 KB |
| AllocateArrayPool    | 3      | 2,136.7 ns | 1,372.8 ns |  75.25 ns | 2,050.3 ns | 2,187.4 ns | 0.0343 | 0.0305 |   3.07 KB |
