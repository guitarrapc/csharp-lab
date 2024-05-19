```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.9779 ns** |  **0.3412 ns** | **0.0187 ns** |  **64.9587 ns** |  **64.9960 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.3001 ns |  0.1737 ns | 0.0095 ns |  74.2946 ns |  74.3111 ns |         - |
| TryParseCidrBytes  | 1      |   3.0304 ns |  0.0191 ns | 0.0010 ns |   3.0295 ns |   3.0315 ns |         - |
| **NewFromCidrString**  | **3**      | **198.2082 ns** | **10.7672 ns** | **0.5902 ns** | **197.8592 ns** | **198.8896 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6034 ns |  0.1068 ns | 0.0059 ns |   0.5997 ns |   0.6101 ns |         - |
| TryParseCidrString | 3      | 213.9470 ns |  8.7509 ns | 0.4797 ns | 213.4976 ns | 214.4521 ns |         - |
| TryParseCidrBytes  | 3      |   9.2030 ns |  1.6848 ns | 0.0924 ns |   9.1494 ns |   9.3096 ns |         - |
