```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.7450 ns** | **0.8666 ns** | **0.0475 ns** |  **65.7322 ns** |  **65.7052 ns** |  **65.7976 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0466 ns | 0.8371 ns | 0.0459 ns |   0.0212 ns |   0.0189 ns |   0.0995 ns |         - |
| TryParseCidrString | 1      |  72.2234 ns | 3.7893 ns | 0.2077 ns |  72.1700 ns |  72.0477 ns |  72.4527 ns |         - |
| TryParseCidrBytes  | 1      |   2.7477 ns | 0.0905 ns | 0.0050 ns |   2.7460 ns |   2.7438 ns |   2.7533 ns |         - |
| **NewFromCidrString**  | **3**      | **203.5731 ns** | **7.7241 ns** | **0.4234 ns** | **203.6238 ns** | **203.1267 ns** | **203.9689 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6791 ns | 1.3050 ns | 0.0715 ns |   0.6380 ns |   0.6376 ns |   0.7617 ns |         - |
| TryParseCidrString | 3      | 210.0752 ns | 7.4354 ns | 0.4076 ns | 210.1218 ns | 209.6464 ns | 210.4575 ns |         - |
| TryParseCidrBytes  | 3      |   9.3834 ns | 3.4797 ns | 0.1907 ns |   9.3179 ns |   9.2340 ns |   9.5982 ns |         - |
