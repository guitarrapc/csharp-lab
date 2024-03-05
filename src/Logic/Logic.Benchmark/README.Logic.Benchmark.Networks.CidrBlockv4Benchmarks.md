```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.7997 ns** |  **2.0212 ns** | **0.1108 ns** |  **64.6868 ns** |  **64.9083 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.4551 ns |  1.0352 ns | 0.0567 ns |  74.4137 ns |  74.5198 ns |         - |
| TryParseCidrBytes  | 1      |   2.6691 ns |  0.1405 ns | 0.0077 ns |   2.6619 ns |   2.6772 ns |         - |
| **NewFromCidrString**  | **3**      | **196.9714 ns** | **53.9654 ns** | **2.9580 ns** | **194.9395 ns** | **200.3651 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6007 ns |  0.0500 ns | 0.0027 ns |   0.5983 ns |   0.6037 ns |         - |
| TryParseCidrString | 3      | 214.9399 ns | 58.3883 ns | 3.2005 ns | 213.0504 ns | 218.6352 ns |         - |
| TryParseCidrBytes  | 3      |   9.1371 ns |  2.0342 ns | 0.1115 ns |   9.0123 ns |   9.2269 ns |         - |
