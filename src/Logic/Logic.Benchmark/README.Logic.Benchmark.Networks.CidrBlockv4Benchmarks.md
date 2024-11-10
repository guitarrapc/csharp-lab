```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.4253 ns** |  **1.4331 ns** | **0.0786 ns** |  **64.3770 ns** |  **64.5160 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0233 ns |  0.0213 ns | 0.0012 ns |   0.0220 ns |   0.0243 ns |         - |
| TryParseCidrString | 1      |  74.7727 ns |  1.2329 ns | 0.0676 ns |  74.7017 ns |  74.8363 ns |         - |
| TryParseCidrBytes  | 1      |   2.7439 ns |  0.0563 ns | 0.0031 ns |   2.7415 ns |   2.7474 ns |         - |
| **NewFromCidrString**  | **3**      | **197.3826 ns** | **10.4091 ns** | **0.5706 ns** | **196.8443 ns** | **197.9807 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6387 ns |  0.0355 ns | 0.0019 ns |   0.6373 ns |   0.6409 ns |         - |
| TryParseCidrString | 3      | 207.9276 ns |  5.1285 ns | 0.2811 ns | 207.7622 ns | 208.2522 ns |         - |
| TryParseCidrBytes  | 3      |   9.3787 ns |  0.2219 ns | 0.0122 ns |   9.3650 ns |   9.3882 ns |         - |
