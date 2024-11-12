```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.5715 ns** | **0.3601 ns** | **0.0197 ns** |  **65.5514 ns** |  **65.5909 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0205 ns | 0.0067 ns | 0.0004 ns |   0.0202 ns |   0.0209 ns |         - |
| TryParseCidrString | 1      |  74.0189 ns | 1.5433 ns | 0.0846 ns |  73.9608 ns |  74.1159 ns |         - |
| TryParseCidrBytes  | 1      |   2.8038 ns | 1.5355 ns | 0.0842 ns |   2.7525 ns |   2.9009 ns |         - |
| **NewFromCidrString**  | **3**      | **207.3822 ns** | **1.8374 ns** | **0.1007 ns** | **207.2781 ns** | **207.4791 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6398 ns | 0.0439 ns | 0.0024 ns |   0.6370 ns |   0.6413 ns |         - |
| TryParseCidrString | 3      | 210.0434 ns | 4.1372 ns | 0.2268 ns | 209.8948 ns | 210.3044 ns |         - |
| TryParseCidrBytes  | 3      |   9.3176 ns | 1.0586 ns | 0.0580 ns |   9.2621 ns |   9.3778 ns |         - |
