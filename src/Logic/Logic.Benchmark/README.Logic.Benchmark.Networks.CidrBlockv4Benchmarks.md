```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.6428 ns** |  **5.7089 ns** | **0.3129 ns** |  **65.4328 ns** |  **66.0025 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0221 ns |  0.0051 ns | 0.0003 ns |   0.0218 ns |   0.0224 ns |         - |
| TryParseCidrString | 1      |  73.3865 ns |  6.2021 ns | 0.3400 ns |  72.9994 ns |  73.6367 ns |         - |
| TryParseCidrBytes  | 1      |   2.7578 ns |  0.4032 ns | 0.0221 ns |   2.7424 ns |   2.7831 ns |         - |
| **NewFromCidrString**  | **3**      | **207.2778 ns** | **24.4173 ns** | **1.3384 ns** | **205.8035 ns** | **208.4163 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6612 ns |  0.3767 ns | 0.0206 ns |   0.6380 ns |   0.6777 ns |         - |
| TryParseCidrString | 3      | 513.1922 ns | 15.4683 ns | 0.8479 ns | 512.2192 ns | 513.7730 ns |         - |
| TryParseCidrBytes  | 3      |   9.3358 ns |  0.5448 ns | 0.0299 ns |   9.3074 ns |   9.3669 ns |         - |
