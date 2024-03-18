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
| **NewFromCidrString**  | **1**      |  **65.2503 ns** |  **8.6108 ns** | **0.4720 ns** |  **64.9362 ns** |  **65.7931 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.8336 ns |  6.0879 ns | 0.3337 ns |  73.4883 ns |  74.1543 ns |         - |
| TryParseCidrBytes  | 1      |   3.0464 ns |  0.2214 ns | 0.0121 ns |   3.0353 ns |   3.0594 ns |         - |
| **NewFromCidrString**  | **3**      | **195.8068 ns** |  **9.3886 ns** | **0.5146 ns** | **195.3039 ns** | **196.3324 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6043 ns |  0.1348 ns | 0.0074 ns |   0.5998 ns |   0.6128 ns |         - |
| TryParseCidrString | 3      | 212.2744 ns | 10.1057 ns | 0.5539 ns | 211.7205 ns | 212.8283 ns |         - |
| TryParseCidrBytes  | 3      |   9.3170 ns |  0.9087 ns | 0.0498 ns |   9.2756 ns |   9.3723 ns |         - |
