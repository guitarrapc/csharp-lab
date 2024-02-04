```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error       | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|------------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.3022 ns** |   **2.5595 ns** | **0.1403 ns** |  **65.1601 ns** |  **65.4406 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |   0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8612 ns |   1.4959 ns | 0.0820 ns |  73.8023 ns |  73.9548 ns |         - |
| TryParseCidrBytes  | 1      |   3.1154 ns |   2.4184 ns | 0.1326 ns |   3.0345 ns |   3.2683 ns |         - |
| **NewFromCidrString**  | **10**     | **665.1002 ns** |  **95.0551 ns** | **5.2103 ns** | **659.0863 ns** | **668.2551 ns** |         **-** |
| NewFromCirBytes    | 10     |   3.3017 ns |   0.0702 ns | 0.0038 ns |   3.2980 ns |   3.3057 ns |         - |
| TryParseCidrString | 10     | 712.5486 ns | 148.1268 ns | 8.1193 ns | 707.6881 ns | 721.9218 ns |         - |
| TryParseCidrBytes  | 10     |  28.4856 ns |   0.2229 ns | 0.0122 ns |  28.4730 ns |  28.4973 ns |         - |
