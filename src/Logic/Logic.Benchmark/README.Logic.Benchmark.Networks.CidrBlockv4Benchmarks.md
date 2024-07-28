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
| **NewFromCidrString**  | **1**      |  **67.8810 ns** |  **1.6058 ns** | **0.0880 ns** |  **67.8193 ns** |  **67.9818 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.6869 ns |  5.8996 ns | 0.3234 ns |  73.3164 ns |  73.9126 ns |         - |
| TryParseCidrBytes  | 1      |   3.0355 ns |  0.0844 ns | 0.0046 ns |   3.0328 ns |   3.0408 ns |         - |
| **NewFromCidrString**  | **3**      | **194.8030 ns** |  **2.3295 ns** | **0.1277 ns** | **194.6781 ns** | **194.9333 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6098 ns |  0.1453 ns | 0.0080 ns |   0.6022 ns |   0.6181 ns |         - |
| TryParseCidrString | 3      | 215.4063 ns | 26.1113 ns | 1.4312 ns | 213.9097 ns | 216.7618 ns |         - |
| TryParseCidrBytes  | 3      |   9.2329 ns |  1.7785 ns | 0.0975 ns |   9.1539 ns |   9.3419 ns |         - |
