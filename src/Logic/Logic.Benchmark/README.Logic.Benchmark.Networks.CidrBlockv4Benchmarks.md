```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.8042 ns** |  **1.9443 ns** | **0.1066 ns** |  **64.6957 ns** |  **64.9088 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0243 ns |  0.0243 ns | 0.0013 ns |   0.0228 ns |   0.0254 ns |         - |
| TryParseCidrString | 1      |  72.1551 ns |  3.6421 ns | 0.1996 ns |  71.9564 ns |  72.3556 ns |         - |
| TryParseCidrBytes  | 1      |   2.7494 ns |  0.0750 ns | 0.0041 ns |   2.7467 ns |   2.7542 ns |         - |
| **NewFromCidrString**  | **3**      | **199.1232 ns** | **14.7718 ns** | **0.8097 ns** | **198.6198 ns** | **200.0572 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6391 ns |  0.1149 ns | 0.0063 ns |   0.6328 ns |   0.6454 ns |         - |
| TryParseCidrString | 3      | 209.3862 ns | 17.5024 ns | 0.9594 ns | 208.5400 ns | 210.4284 ns |         - |
| TryParseCidrBytes  | 3      |   9.3193 ns |  1.0603 ns | 0.0581 ns |   9.2749 ns |   9.3850 ns |         - |
