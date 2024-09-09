```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2046 ns** | **12.5456 ns** | **0.6877 ns** |  **64.8011 ns** |  **65.9986 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0236 ns |  0.0506 ns | 0.0028 ns |   0.0215 ns |   0.0268 ns |         - |
| TryParseCidrString | 1      |  72.7081 ns |  7.5408 ns | 0.4133 ns |  72.4502 ns |  73.1849 ns |         - |
| TryParseCidrBytes  | 1      |   2.7445 ns |  0.0412 ns | 0.0023 ns |   2.7431 ns |   2.7471 ns |         - |
| **NewFromCidrString**  | **3**      | **197.9088 ns** | **20.1905 ns** | **1.1067 ns** | **197.1204 ns** | **199.1740 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6419 ns |  0.1018 ns | 0.0056 ns |   0.6367 ns |   0.6478 ns |         - |
| TryParseCidrString | 3      | 209.8680 ns | 15.9548 ns | 0.8745 ns | 209.2922 ns | 210.8744 ns |         - |
| TryParseCidrBytes  | 3      |   9.3269 ns |  1.7870 ns | 0.0980 ns |   9.2297 ns |   9.4256 ns |         - |
