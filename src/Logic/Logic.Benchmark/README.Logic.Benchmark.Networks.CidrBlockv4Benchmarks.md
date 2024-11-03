```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.3320 ns** | **2.6509 ns** | **0.1453 ns** |  **65.2122 ns** |  **65.4937 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0214 ns | 0.0187 ns | 0.0010 ns |   0.0202 ns |   0.0222 ns |         - |
| TryParseCidrString | 1      |  72.1070 ns | 1.8891 ns | 0.1035 ns |  71.9916 ns |  72.1919 ns |         - |
| TryParseCidrBytes  | 1      |   2.7450 ns | 0.0171 ns | 0.0009 ns |   2.7440 ns |   2.7459 ns |         - |
| **NewFromCidrString**  | **3**      | **196.0725 ns** | **7.0388 ns** | **0.3858 ns** | **195.7616 ns** | **196.5043 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.2300 ns | 0.0675 ns | 0.0037 ns |   0.2279 ns |   0.2343 ns |         - |
| TryParseCidrString | 3      | 210.0017 ns | 2.3200 ns | 0.1272 ns | 209.8874 ns | 210.1386 ns |         - |
| TryParseCidrBytes  | 3      |   9.3530 ns | 1.7084 ns | 0.0936 ns |   9.2925 ns |   9.4609 ns |         - |
