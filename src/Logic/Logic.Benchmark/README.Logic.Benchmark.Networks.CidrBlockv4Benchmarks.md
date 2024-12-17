```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **49.9047 ns** |  **0.6250 ns** | **0.0343 ns** |  **49.8721 ns** |  **49.9404 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6177 ns |  0.0071 ns | 0.0004 ns |   0.6173 ns |   0.6180 ns |         - |
| TryParseCidrString | 1      |  52.3722 ns |  0.8636 ns | 0.0473 ns |  52.3180 ns |  52.4056 ns |         - |
| TryParseCidrBytes  | 1      |   3.0406 ns |  0.5107 ns | 0.0280 ns |   3.0223 ns |   3.0728 ns |         - |
| **NewFromCidrString**  | **3**      | **149.6606 ns** |  **3.8898 ns** | **0.2132 ns** | **149.5214 ns** | **149.9061 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6206 ns |  0.0427 ns | 0.0023 ns |   0.6182 ns |   0.6229 ns |         - |
| TryParseCidrString | 3      | 155.8211 ns | 22.6635 ns | 1.2423 ns | 154.4493 ns | 156.8700 ns |         - |
| TryParseCidrBytes  | 3      |   8.9511 ns |  0.6597 ns | 0.0362 ns |   8.9109 ns |   8.9811 ns |         - |
