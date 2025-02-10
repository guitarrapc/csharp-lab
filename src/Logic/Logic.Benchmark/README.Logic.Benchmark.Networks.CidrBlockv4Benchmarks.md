```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.2190 ns** |  **3.1661 ns** | **0.1735 ns** |  **50.0210 ns** |  **50.3448 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6269 ns |  0.0913 ns | 0.0050 ns |   0.6234 ns |   0.6326 ns |         - |
| TryParseCidrString | 1      |  52.5899 ns |  0.3396 ns | 0.0186 ns |  52.5690 ns |  52.6047 ns |         - |
| TryParseCidrBytes  | 1      |   3.0928 ns |  0.0740 ns | 0.0041 ns |   3.0898 ns |   3.0974 ns |         - |
| **NewFromCidrString**  | **3**      | **149.9368 ns** | **14.0850 ns** | **0.7720 ns** | **149.1601 ns** | **150.7041 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6269 ns |  0.1090 ns | 0.0060 ns |   0.6212 ns |   0.6331 ns |         - |
| TryParseCidrString | 3      | 155.7718 ns |  9.2472 ns | 0.5069 ns | 155.4422 ns | 156.3554 ns |         - |
| TryParseCidrBytes  | 3      |   9.3612 ns |  0.8884 ns | 0.0487 ns |   9.3184 ns |   9.4142 ns |         - |
