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
| **NewFromCidrString**  | **1**      |  **65.9333 ns** | **16.0144 ns** | **0.8778 ns** |  **65.4227 ns** |  **66.9469 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.0953 ns |  3.0895 ns | 0.1693 ns |  73.9942 ns |  74.2908 ns |         - |
| TryParseCidrBytes  | 1      |   3.0473 ns |  0.1985 ns | 0.0109 ns |   3.0360 ns |   3.0577 ns |         - |
| **NewFromCidrString**  | **3**      | **198.9852 ns** | **18.6839 ns** | **1.0241 ns** | **198.2891 ns** | **200.1612 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6004 ns |  0.0440 ns | 0.0024 ns |   0.5981 ns |   0.6029 ns |         - |
| TryParseCidrString | 3      | 212.9019 ns |  5.6657 ns | 0.3106 ns | 212.6297 ns | 213.2402 ns |         - |
| TryParseCidrBytes  | 3      |   9.1773 ns |  1.0010 ns | 0.0549 ns |   9.1139 ns |   9.2091 ns |         - |
