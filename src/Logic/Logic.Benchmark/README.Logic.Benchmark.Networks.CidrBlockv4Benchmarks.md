```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.5954 ns** |  **2.6729 ns** | **0.1465 ns** |  **50.4268 ns** |  **50.6921 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6557 ns |  1.0866 ns | 0.0596 ns |   0.6211 ns |   0.7245 ns |         - |
| TryParseCidrString | 1      |  52.3616 ns |  2.8846 ns | 0.1581 ns |  52.1807 ns |  52.4732 ns |         - |
| TryParseCidrBytes  | 1      |   3.1054 ns |  0.3370 ns | 0.0185 ns |   3.0920 ns |   3.1264 ns |         - |
| **NewFromCidrString**  | **3**      | **147.7771 ns** |  **7.4971 ns** | **0.4109 ns** | **147.5344 ns** | **148.2515 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6232 ns |  0.0424 ns | 0.0023 ns |   0.6211 ns |   0.6257 ns |         - |
| TryParseCidrString | 3      | 156.5010 ns | 18.2593 ns | 1.0009 ns | 155.7620 ns | 157.6400 ns |         - |
| TryParseCidrBytes  | 3      |   9.4432 ns |  0.9225 ns | 0.0506 ns |   9.4057 ns |   9.5007 ns |         - |
