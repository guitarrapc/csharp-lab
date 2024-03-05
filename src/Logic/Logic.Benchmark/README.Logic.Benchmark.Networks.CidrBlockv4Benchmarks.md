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
| **NewFromCidrString**  | **1**      |  **64.7183 ns** |  **4.6520 ns** | **0.2550 ns** |  **64.5128 ns** |  **65.0037 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.0548 ns |  2.9749 ns | 0.1631 ns |  72.9316 ns |  73.2397 ns |         - |
| TryParseCidrBytes  | 1      |   3.0504 ns |  0.5445 ns | 0.0298 ns |   3.0331 ns |   3.0849 ns |         - |
| **NewFromCidrString**  | **3**      | **196.0971 ns** | **10.3038 ns** | **0.5648 ns** | **195.7279 ns** | **196.7472 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6028 ns |  0.0128 ns | 0.0007 ns |   0.6023 ns |   0.6036 ns |         - |
| TryParseCidrString | 3      | 212.4989 ns |  8.1689 ns | 0.4478 ns | 212.2242 ns | 213.0156 ns |         - |
| TryParseCidrBytes  | 3      |   9.3734 ns |  4.7146 ns | 0.2584 ns |   9.0963 ns |   9.6078 ns |         - |
