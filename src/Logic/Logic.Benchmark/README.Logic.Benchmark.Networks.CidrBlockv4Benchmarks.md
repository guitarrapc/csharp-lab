```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.0039 ns** |  **0.7097 ns** | **0.0389 ns** |  **49.9591 ns** |  **50.0280 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6219 ns |  0.0050 ns | 0.0003 ns |   0.6216 ns |   0.6221 ns |         - |
| TryParseCidrString | 1      |  52.7926 ns |  1.3402 ns | 0.0735 ns |  52.7239 ns |  52.8700 ns |         - |
| TryParseCidrBytes  | 1      |   3.1067 ns |  0.3041 ns | 0.0167 ns |   3.0882 ns |   3.1207 ns |         - |
| **NewFromCidrString**  | **3**      | **152.4064 ns** | **63.9075 ns** | **3.5030 ns** | **148.3617 ns** | **154.4603 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6266 ns |  0.0444 ns | 0.0024 ns |   0.6242 ns |   0.6291 ns |         - |
| TryParseCidrString | 3      | 156.1628 ns |  9.4423 ns | 0.5176 ns | 155.6592 ns | 156.6933 ns |         - |
| TryParseCidrBytes  | 3      |   9.3453 ns |  0.8400 ns | 0.0460 ns |   9.2971 ns |   9.3888 ns |         - |
