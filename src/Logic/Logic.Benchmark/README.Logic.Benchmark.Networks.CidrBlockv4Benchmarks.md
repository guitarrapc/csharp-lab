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
| **NewFromCidrString**  | **1**      |  **65.6135 ns** |  **1.7214 ns** | **0.0944 ns** |  **65.5364 ns** |  **65.7187 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  75.1587 ns |  3.9556 ns | 0.2168 ns |  74.9102 ns |  75.3098 ns |         - |
| TryParseCidrBytes  | 1      |   3.0399 ns |  0.1292 ns | 0.0071 ns |   3.0330 ns |   3.0472 ns |         - |
| **NewFromCidrString**  | **3**      | **198.4174 ns** | **41.2160 ns** | **2.2592 ns** | **197.0141 ns** | **201.0236 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.3110 ns |  0.2319 ns | 0.0127 ns |   0.2980 ns |   0.3234 ns |         - |
| TryParseCidrString | 3      | 213.8018 ns | 57.0853 ns | 3.1290 ns | 211.6077 ns | 217.3848 ns |         - |
| TryParseCidrBytes  | 3      |   9.4256 ns |  2.2492 ns | 0.1233 ns |   9.2871 ns |   9.5235 ns |         - |
