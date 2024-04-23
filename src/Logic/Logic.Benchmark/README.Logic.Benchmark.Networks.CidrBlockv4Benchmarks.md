```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.7025 ns** |  **0.4699 ns** | **0.0258 ns** |  **64.7133 ns** |  **64.6732 ns** |  **64.7212 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0191 ns |  0.3185 ns | 0.0175 ns |   0.0232 ns |   0.0000 ns |   0.0342 ns |         - |
| TryParseCidrString | 1      |  74.4015 ns | 11.4885 ns | 0.6297 ns |  74.5282 ns |  73.7181 ns |  74.9582 ns |         - |
| TryParseCidrBytes  | 1      |   3.0348 ns |  0.0581 ns | 0.0032 ns |   3.0351 ns |   3.0314 ns |   3.0378 ns |         - |
| **NewFromCidrString**  | **3**      | **197.0347 ns** | **42.6942 ns** | **2.3402 ns** | **195.7150 ns** | **195.6524 ns** | **199.7367 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6293 ns |  0.9173 ns | 0.0503 ns |   0.6028 ns |   0.5978 ns |   0.6873 ns |         - |
| TryParseCidrString | 3      | 214.2844 ns |  2.9621 ns | 0.1624 ns | 214.3378 ns | 214.1020 ns | 214.4133 ns |         - |
| TryParseCidrBytes  | 3      |   9.3236 ns |  2.2545 ns | 0.1236 ns |   9.3405 ns |   9.1924 ns |   9.4378 ns |         - |
