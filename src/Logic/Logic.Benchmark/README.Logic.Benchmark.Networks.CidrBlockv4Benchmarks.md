```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev     | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|-----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0178 ns** |   **0.7777 ns** |  **0.0426 ns** |  **64.9889 ns** |  **65.0668 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |   0.0000 ns |  0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.1850 ns |   0.3994 ns |  0.0219 ns |  74.1614 ns |  74.2046 ns |         - |
| TryParseCidrBytes  | 1      |   3.0449 ns |   0.2201 ns |  0.0121 ns |   3.0367 ns |   3.0587 ns |         - |
| **NewFromCidrString**  | **10**     | **671.4681 ns** | **305.2200 ns** | **16.7301 ns** | **661.5039 ns** | **690.7832 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.2997 ns |   0.0698 ns |  0.0038 ns |   3.2960 ns |   3.3036 ns |         - |
| TryParseCidrString | 10     | 703.6488 ns |  35.8335 ns |  1.9642 ns | 701.8645 ns | 705.7534 ns |         - |
| TryParseCidrBytes  | 10     |  28.5946 ns |   2.6793 ns |  0.1469 ns |  28.5078 ns |  28.7642 ns |         - |
