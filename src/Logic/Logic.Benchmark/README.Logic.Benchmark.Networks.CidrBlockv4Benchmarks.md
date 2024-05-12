```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **66.9506 ns** | **0.2301 ns** | **0.0126 ns** |  **66.9362 ns** |  **66.9597 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.4523 ns | 0.5871 ns | 0.0322 ns |  73.4152 ns |  73.4726 ns |         - |
| TryParseCidrBytes  | 1      |   3.0363 ns | 0.0783 ns | 0.0043 ns |   3.0330 ns |   3.0412 ns |         - |
| **NewFromCidrString**  | **3**      | **196.8590 ns** | **8.2221 ns** | **0.4507 ns** | **196.3702 ns** | **197.2581 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6000 ns | 0.0259 ns | 0.0014 ns |   0.5989 ns |   0.6016 ns |         - |
| TryParseCidrString | 3      | 215.1604 ns | 0.9550 ns | 0.0523 ns | 215.1117 ns | 215.2158 ns |         - |
| TryParseCidrBytes  | 3      |   9.4952 ns | 1.6643 ns | 0.0912 ns |   9.3997 ns |   9.5814 ns |         - |
