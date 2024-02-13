```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.9841 ns** |   **4.3073 ns** | **0.2361 ns** |  **65.1119 ns** |  **64.7116 ns** |  **65.1287 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0038 ns |   0.1214 ns | 0.0067 ns |   0.0000 ns |   0.0000 ns |   0.0115 ns |         - |
| TryParseCidrString | 1      |  71.5883 ns |  13.2741 ns | 0.7276 ns |  71.8184 ns |  70.7735 ns |  72.1731 ns |         - |
| TryParseCidrBytes  | 1      |   3.0450 ns |   0.2591 ns | 0.0142 ns |   3.0448 ns |   3.0309 ns |   3.0593 ns |         - |
| **NewFromCidrString**  | **10**     | **645.6654 ns** | **177.0306 ns** | **9.7036 ns** | **650.5357 ns** | **634.4912 ns** | **651.9693 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.2303 ns |   0.8173 ns | 0.0448 ns |   3.2466 ns |   3.1796 ns |   3.2646 ns |         - |
| TryParseCidrString | 10     | 714.7268 ns | 171.1034 ns | 9.3788 ns | 719.7646 ns | 703.9057 ns | 720.5101 ns |         - |
| TryParseCidrBytes  | 10     |  27.3424 ns |   3.3323 ns | 0.1827 ns |  27.3984 ns |  27.1383 ns |  27.4905 ns |         - |
