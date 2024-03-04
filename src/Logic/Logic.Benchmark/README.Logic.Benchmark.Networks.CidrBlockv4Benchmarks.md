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
| **NewFromCidrString**  | **1**      |  **60.1647 ns** |  **3.7728 ns** | **0.2068 ns** |  **59.9592 ns** |  **60.3728 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  68.4836 ns |  1.7201 ns | 0.0943 ns |  68.3929 ns |  68.5811 ns |         - |
| TryParseCidrBytes  | 1      |   2.8283 ns |  0.1687 ns | 0.0092 ns |   2.8181 ns |   2.8361 ns |         - |
| **NewFromCidrString**  | **10**     | **609.7847 ns** | **72.2310 ns** | **3.9592 ns** | **607.2539 ns** | **614.3473 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.1012 ns |  0.5241 ns | 0.0287 ns |   3.0773 ns |   3.1331 ns |         - |
| TryParseCidrString | 10     | 652.7137 ns | 26.8439 ns | 1.4714 ns | 651.6847 ns | 654.3990 ns |         - |
| TryParseCidrBytes  | 10     |  26.7508 ns |  2.2448 ns | 0.1230 ns |  26.6515 ns |  26.8885 ns |         - |
