```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.7883 ns** |  **3.0046 ns** | **0.1647 ns** |  **65.6213 ns** |  **65.9505 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  77.3017 ns | 29.0248 ns | 1.5909 ns |  76.3341 ns |  79.1378 ns |         - |
| TryParseCidrBytes  | 1      |   3.0443 ns |  0.2193 ns | 0.0120 ns |   3.0325 ns |   3.0566 ns |         - |
| **NewFromCidrString**  | **3**      | **197.8020 ns** | **18.3359 ns** | **1.0051 ns** | **197.2081 ns** | **198.9625 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6013 ns |  0.0270 ns | 0.0015 ns |   0.5996 ns |   0.6023 ns |         - |
| TryParseCidrString | 3      | 218.9493 ns | 20.9349 ns | 1.1475 ns | 217.9363 ns | 220.1955 ns |         - |
| TryParseCidrBytes  | 3      |   9.1877 ns |  0.4954 ns | 0.0272 ns |   9.1576 ns |   9.2102 ns |         - |
