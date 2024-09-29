```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.4797 ns** |  **1.0663 ns** | **0.0585 ns** |  **67.4245 ns** |  **67.5409 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0044 ns |  0.0107 ns | 0.0006 ns |   0.0037 ns |   0.0049 ns |         - |
| TryParseCidrString | 1      |  71.3257 ns | 18.3446 ns | 1.0055 ns |  70.6616 ns |  72.4826 ns |         - |
| TryParseCidrBytes  | 1      |   2.7067 ns |  0.3806 ns | 0.0209 ns |   2.6831 ns |   2.7227 ns |         - |
| **NewFromCidrString**  | **3**      | **191.3075 ns** |  **4.0666 ns** | **0.2229 ns** | **191.0894 ns** | **191.5349 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6399 ns |  0.2198 ns | 0.0120 ns |   0.6276 ns |   0.6517 ns |         - |
| TryParseCidrString | 3      | 206.8738 ns | 22.7343 ns | 1.2461 ns | 205.5631 ns | 208.0434 ns |         - |
| TryParseCidrBytes  | 3      |   9.0272 ns |  1.7754 ns | 0.0973 ns |   8.9224 ns |   9.1146 ns |         - |
