```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **61.9424 ns** | **17.4004 ns** | **0.9538 ns** |  **61.2244 ns** |  **63.0246 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0144 ns |  0.2369 ns | 0.0130 ns |   0.0021 ns |   0.0280 ns |         - |
| TryParseCidrString | 1      |  71.4334 ns | 11.8052 ns | 0.6471 ns |  70.6926 ns |  71.8885 ns |         - |
| TryParseCidrBytes  | 1      |   3.1710 ns |  6.3903 ns | 0.3503 ns |   2.8432 ns |   3.5401 ns |         - |
| **NewFromCidrString**  | **3**      | **197.4616 ns** | **38.0734 ns** | **2.0869 ns** | **195.0584 ns** | **198.8171 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.5947 ns |  0.5455 ns | 0.0299 ns |   0.5604 ns |   0.6154 ns |         - |
| TryParseCidrString | 3      | 204.2451 ns | 24.9197 ns | 1.3659 ns | 202.7298 ns | 205.3818 ns |         - |
| TryParseCidrBytes  | 3      |   8.7306 ns |  2.0610 ns | 0.1130 ns |   8.6447 ns |   8.8586 ns |         - |
