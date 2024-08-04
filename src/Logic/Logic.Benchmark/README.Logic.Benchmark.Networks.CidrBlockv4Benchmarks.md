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
| **NewFromCidrString**  | **1**      |  **64.7434 ns** | **3.9536 ns** | **0.2167 ns** |  **64.6005 ns** |  **64.9927 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.0072 ns | 3.9642 ns | 0.2173 ns |  73.8191 ns |  74.2451 ns |         - |
| TryParseCidrBytes  | 1      |   3.0538 ns | 0.7739 ns | 0.0424 ns |   3.0285 ns |   3.1028 ns |         - |
| **NewFromCidrString**  | **3**      | **204.3740 ns** | **1.6038 ns** | **0.0879 ns** | **204.2930 ns** | **204.4675 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6049 ns | 0.0552 ns | 0.0030 ns |   0.6015 ns |   0.6074 ns |         - |
| TryParseCidrString | 3      | 214.0047 ns | 8.2849 ns | 0.4541 ns | 213.5698 ns | 214.4759 ns |         - |
| TryParseCidrBytes  | 3      |   9.2989 ns | 1.4319 ns | 0.0785 ns |   9.2466 ns |   9.3891 ns |         - |
