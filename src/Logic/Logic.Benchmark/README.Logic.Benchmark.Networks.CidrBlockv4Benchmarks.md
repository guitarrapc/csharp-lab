```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.0223 ns** | **2.7107 ns** | **0.1486 ns** |  **49.8548 ns** |  **50.1383 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6210 ns | 0.0707 ns | 0.0039 ns |   0.6171 ns |   0.6249 ns |         - |
| TryParseCidrString | 1      |  57.1918 ns | 3.6525 ns | 0.2002 ns |  56.9618 ns |  57.3267 ns |         - |
| TryParseCidrBytes  | 1      |   3.0175 ns | 0.0357 ns | 0.0020 ns |   3.0160 ns |   3.0197 ns |         - |
| **NewFromCidrString**  | **3**      | **148.4253 ns** | **7.9075 ns** | **0.4334 ns** | **147.9730 ns** | **148.8371 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.4212 ns | 0.1249 ns | 0.0068 ns |   0.4168 ns |   0.4291 ns |         - |
| TryParseCidrString | 3      | 155.0854 ns | 5.0519 ns | 0.2769 ns | 154.8207 ns | 155.3731 ns |         - |
| TryParseCidrBytes  | 3      |   8.9067 ns | 1.4967 ns | 0.0820 ns |   8.8202 ns |   8.9834 ns |         - |
