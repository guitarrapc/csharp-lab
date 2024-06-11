```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.6722 ns** |  **4.2397 ns** | **0.2324 ns** |  **65.4116 ns** |  **65.8581 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.3380 ns | 21.1817 ns | 1.1610 ns |  73.4789 ns |  75.6589 ns |         - |
| TryParseCidrBytes  | 1      |   3.0426 ns |  0.2395 ns | 0.0131 ns |   3.0339 ns |   3.0577 ns |         - |
| **NewFromCidrString**  | **3**      | **199.3546 ns** | **62.7179 ns** | **3.4378 ns** | **197.2595 ns** | **203.3221 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6018 ns |  0.0241 ns | 0.0013 ns |   0.6010 ns |   0.6034 ns |         - |
| TryParseCidrString | 3      | 214.1264 ns |  9.8283 ns | 0.5387 ns | 213.5093 ns | 214.5032 ns |         - |
| TryParseCidrBytes  | 3      |   9.1079 ns |  0.0387 ns | 0.0021 ns |   9.1063 ns |   9.1103 ns |         - |
