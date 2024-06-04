```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.0169 ns** |  **5.9914 ns** | **0.3284 ns** |  **66.8914 ns** |  **66.7698 ns** |  **67.3896 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0101 ns |  0.3205 ns | 0.0176 ns |   0.0000 ns |   0.0000 ns |   0.0304 ns |         - |
| TryParseCidrString | 1      |  75.4484 ns |  7.1801 ns | 0.3936 ns |  75.2739 ns |  75.1722 ns |  75.8990 ns |         - |
| TryParseCidrBytes  | 1      |   3.0389 ns |  0.0852 ns | 0.0047 ns |   3.0409 ns |   3.0336 ns |   3.0422 ns |         - |
| **NewFromCidrString**  | **3**      | **199.9348 ns** | **35.5286 ns** | **1.9474 ns** | **198.8703 ns** | **198.7516 ns** | **202.1825 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6014 ns |  0.0796 ns | 0.0044 ns |   0.5991 ns |   0.5986 ns |   0.6064 ns |         - |
| TryParseCidrString | 3      | 215.0442 ns |  6.7733 ns | 0.3713 ns | 214.9616 ns | 214.7212 ns | 215.4498 ns |         - |
| TryParseCidrBytes  | 3      |   9.0768 ns |  1.8725 ns | 0.1026 ns |   9.0420 ns |   8.9961 ns |   9.1923 ns |         - |
