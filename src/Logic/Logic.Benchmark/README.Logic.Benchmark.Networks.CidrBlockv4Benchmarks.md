```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.5282 ns** | **2.7088 ns** | **0.1485 ns** |  **64.3684 ns** |  **64.6619 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0251 ns | 0.0606 ns | 0.0033 ns |   0.0231 ns |   0.0289 ns |         - |
| TryParseCidrString | 1      |  72.8625 ns | 0.8953 ns | 0.0491 ns |  72.8253 ns |  72.9181 ns |         - |
| TryParseCidrBytes  | 1      |   2.7600 ns | 0.2672 ns | 0.0146 ns |   2.7441 ns |   2.7730 ns |         - |
| **NewFromCidrString**  | **3**      | **197.4032 ns** | **2.9160 ns** | **0.1598 ns** | **197.2970 ns** | **197.5870 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6411 ns | 0.0568 ns | 0.0031 ns |   0.6378 ns |   0.6440 ns |         - |
| TryParseCidrString | 3      | 214.4952 ns | 1.0892 ns | 0.0597 ns | 214.4519 ns | 214.5633 ns |         - |
| TryParseCidrBytes  | 3      |   9.2584 ns | 1.3162 ns | 0.0721 ns |   9.1857 ns |   9.3299 ns |         - |
