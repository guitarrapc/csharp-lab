```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.4060 ns** |  **0.4613 ns** | **0.0253 ns** |  **67.3768 ns** |  **67.4214 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.0420 ns |  1.4152 ns | 0.0776 ns |  73.9900 ns |  74.1311 ns |         - |
| TryParseCidrBytes  | 1      |   3.0401 ns |  0.0846 ns | 0.0046 ns |   3.0348 ns |   3.0429 ns |         - |
| **NewFromCidrString**  | **3**      | **202.5297 ns** | **22.2865 ns** | **1.2216 ns** | **201.8161 ns** | **203.9402 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6016 ns |  0.0552 ns | 0.0030 ns |   0.5995 ns |   0.6051 ns |         - |
| TryParseCidrString | 3      | 215.3419 ns | 35.9566 ns | 1.9709 ns | 213.9487 ns | 217.5969 ns |         - |
| TryParseCidrBytes  | 3      |   9.2345 ns |  2.1536 ns | 0.1180 ns |   9.0994 ns |   9.3180 ns |         - |
