```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.5187 ns** | **1.5721 ns** | **0.0862 ns** |  **65.4192 ns** |  **65.5695 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.9024 ns | 1.0490 ns | 0.0575 ns |  73.8368 ns |  73.9444 ns |         - |
| TryParseCidrBytes  | 1      |   3.0355 ns | 0.0216 ns | 0.0012 ns |   3.0344 ns |   3.0368 ns |         - |
| **NewFromCidrString**  | **3**      | **199.3458 ns** | **1.9342 ns** | **0.1060 ns** | **199.2243 ns** | **199.4194 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6127 ns | 0.1533 ns | 0.0084 ns |   0.6065 ns |   0.6222 ns |         - |
| TryParseCidrString | 3      | 214.8780 ns | 3.2825 ns | 0.1799 ns | 214.6799 ns | 215.0312 ns |         - |
| TryParseCidrBytes  | 3      |   9.3672 ns | 2.2567 ns | 0.1237 ns |   9.2258 ns |   9.4556 ns |         - |
