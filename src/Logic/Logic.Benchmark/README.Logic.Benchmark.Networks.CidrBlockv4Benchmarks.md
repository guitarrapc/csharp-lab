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
| **NewFromCidrString**  | **1**      |  **51.6169 ns** | **29.4176 ns** | **1.6125 ns** |  **50.3659 ns** |  **53.4367 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6226 ns |  0.1129 ns | 0.0062 ns |   0.6185 ns |   0.6297 ns |         - |
| TryParseCidrString | 1      |  53.3161 ns |  1.2830 ns | 0.0703 ns |  53.2420 ns |  53.3818 ns |         - |
| TryParseCidrBytes  | 1      |   3.0869 ns |  0.0099 ns | 0.0005 ns |   3.0864 ns |   3.0874 ns |         - |
| **NewFromCidrString**  | **3**      | **149.1541 ns** |  **4.2543 ns** | **0.2332 ns** | **148.9467 ns** | **149.4065 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6232 ns |  0.0114 ns | 0.0006 ns |   0.6225 ns |   0.6238 ns |         - |
| TryParseCidrString | 3      | 155.5084 ns |  7.2023 ns | 0.3948 ns | 155.0610 ns | 155.8080 ns |         - |
| TryParseCidrBytes  | 3      |   9.3878 ns |  2.4259 ns | 0.1330 ns |   9.2835 ns |   9.5375 ns |         - |
