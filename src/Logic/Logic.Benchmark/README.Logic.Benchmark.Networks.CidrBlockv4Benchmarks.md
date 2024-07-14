```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0156 ns** |  **0.7249 ns** | **0.0397 ns** |  **64.9707 ns** |  **65.0463 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.0818 ns |  3.2391 ns | 0.1775 ns |  72.8769 ns |  73.1908 ns |         - |
| TryParseCidrBytes  | 1      |   3.0418 ns |  0.1072 ns | 0.0059 ns |   3.0351 ns |   3.0453 ns |         - |
| **NewFromCidrString**  | **3**      | **198.3077 ns** | **45.1809 ns** | **2.4765 ns** | **196.6545 ns** | **201.1550 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6029 ns |  0.0546 ns | 0.0030 ns |   0.5998 ns |   0.6058 ns |         - |
| TryParseCidrString | 3      | 212.7930 ns |  6.2323 ns | 0.3416 ns | 212.4335 ns | 213.1133 ns |         - |
| TryParseCidrBytes  | 3      |   9.1912 ns |  1.6525 ns | 0.0906 ns |   9.0994 ns |   9.2805 ns |         - |
