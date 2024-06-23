```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.0153 ns** | **1.2520 ns** | **0.0686 ns** |  **64.9424 ns** |  **65.0786 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8312 ns | 5.9486 ns | 0.3261 ns |  73.6225 ns |  74.2069 ns |         - |
| TryParseCidrBytes  | 1      |   3.0513 ns | 0.5169 ns | 0.0283 ns |   3.0348 ns |   3.0840 ns |         - |
| **NewFromCidrString**  | **3**      | **197.6196 ns** | **2.0801 ns** | **0.1140 ns** | **197.4883 ns** | **197.6933 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6065 ns | 0.1720 ns | 0.0094 ns |   0.6003 ns |   0.6174 ns |         - |
| TryParseCidrString | 3      | 214.1701 ns | 4.8173 ns | 0.2641 ns | 213.8794 ns | 214.3950 ns |         - |
| TryParseCidrBytes  | 3      |   9.1310 ns | 1.0772 ns | 0.0590 ns |   9.0871 ns |   9.1981 ns |         - |
