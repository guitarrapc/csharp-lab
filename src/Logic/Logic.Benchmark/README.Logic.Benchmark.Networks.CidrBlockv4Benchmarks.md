```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.2738 ns** | **3.3309 ns** | **0.1826 ns** |  **65.1601 ns** |  **65.4844 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.4254 ns | 1.2810 ns | 0.0702 ns |  73.3671 ns |  73.5033 ns |         - |
| TryParseCidrBytes  | 1      |   3.0355 ns | 0.3269 ns | 0.0179 ns |   3.0188 ns |   3.0545 ns |         - |
| **NewFromCidrString**  | **3**      | **194.1780 ns** | **7.9183 ns** | **0.4340 ns** | **193.7817 ns** | **194.6418 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6011 ns | 0.0588 ns | 0.0032 ns |   0.5989 ns |   0.6048 ns |         - |
| TryParseCidrString | 3      | 214.4429 ns | 8.0266 ns | 0.4400 ns | 214.1440 ns | 214.9481 ns |         - |
| TryParseCidrBytes  | 3      |   9.0428 ns | 0.7647 ns | 0.0419 ns |   8.9948 ns |   9.0722 ns |         - |
