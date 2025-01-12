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
| **NewFromCidrString**  | **1**      |  **47.3724 ns** | **12.9747 ns** | **0.7112 ns** |  **46.7395 ns** |  **48.1420 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6221 ns |  0.8623 ns | 0.0473 ns |   0.5797 ns |   0.6731 ns |         - |
| TryParseCidrString | 1      |  51.1257 ns | 26.7464 ns | 1.4661 ns |  49.4616 ns |  52.2268 ns |         - |
| TryParseCidrBytes  | 1      |   2.9577 ns |  0.9787 ns | 0.0536 ns |   2.8957 ns |   2.9899 ns |         - |
| **NewFromCidrString**  | **3**      | **147.6014 ns** | **10.2914 ns** | **0.5641 ns** | **146.9546 ns** | **147.9915 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.5781 ns |  0.2924 ns | 0.0160 ns |   0.5656 ns |   0.5962 ns |         - |
| TryParseCidrString | 3      | 148.2798 ns | 46.8796 ns | 2.5696 ns | 145.5722 ns | 150.6847 ns |         - |
| TryParseCidrBytes  | 3      |   8.6508 ns |  0.6804 ns | 0.0373 ns |   8.6080 ns |   8.6766 ns |         - |
