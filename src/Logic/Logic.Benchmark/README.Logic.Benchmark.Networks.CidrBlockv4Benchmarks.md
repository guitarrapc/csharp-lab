```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.4129 ns** | **0.2792 ns** | **0.0153 ns** |  **65.3990 ns** |  **65.4293 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0218 ns | 0.0212 ns | 0.0012 ns |   0.0205 ns |   0.0228 ns |         - |
| TryParseCidrString | 1      |  72.6624 ns | 0.9347 ns | 0.0512 ns |  72.6232 ns |  72.7204 ns |         - |
| TryParseCidrBytes  | 1      |   2.7631 ns | 0.1384 ns | 0.0076 ns |   2.7587 ns |   2.7719 ns |         - |
| **NewFromCidrString**  | **3**      | **197.0508 ns** | **2.5141 ns** | **0.1378 ns** | **196.9416 ns** | **197.2056 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6414 ns | 0.0141 ns | 0.0008 ns |   0.6410 ns |   0.6423 ns |         - |
| TryParseCidrString | 3      | 210.9760 ns | 2.2831 ns | 0.1251 ns | 210.8556 ns | 211.1054 ns |         - |
| TryParseCidrBytes  | 3      |   9.4111 ns | 0.9760 ns | 0.0535 ns |   9.3547 ns |   9.4611 ns |         - |
