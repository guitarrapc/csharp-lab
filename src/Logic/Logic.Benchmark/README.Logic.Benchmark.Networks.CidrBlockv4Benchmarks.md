```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0968 ns** |  **0.3856 ns** | **0.0211 ns** |  **65.0815 ns** |  **65.1210 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8643 ns |  1.8895 ns | 0.1036 ns |  73.7698 ns |  73.9750 ns |         - |
| TryParseCidrBytes  | 1      |   3.0504 ns |  0.2073 ns | 0.0114 ns |   3.0379 ns |   3.0602 ns |         - |
| **NewFromCidrString**  | **10**     | **664.8096 ns** | **60.5288 ns** | **3.3178 ns** | **662.1611 ns** | **668.5311 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3913 ns |  0.0693 ns | 0.0038 ns |   3.3869 ns |   3.3938 ns |         - |
| TryParseCidrString | 10     | 709.8777 ns | 13.1968 ns | 0.7234 ns | 709.1291 ns | 710.5728 ns |         - |
| TryParseCidrBytes  | 10     |  28.5154 ns |  0.4909 ns | 0.0269 ns |  28.4962 ns |  28.5461 ns |         - |
