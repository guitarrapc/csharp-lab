```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.8408 ns** | **1.0623 ns** | **0.0582 ns** |  **65.7747 ns** |  **65.8847 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns | 0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  73.3665 ns | 0.5947 ns | 0.0326 ns |  73.3405 ns |  73.4031 ns |         - |
| TryParseCidrBytes  | 1      |   3.0362 ns | 0.0886 ns | 0.0049 ns |   3.0333 ns |   3.0418 ns |         - |
| **NewFromCidrString**  | **3**      | **198.3853 ns** | **0.7301 ns** | **0.0400 ns** | **198.3491 ns** | **198.4283 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6016 ns | 0.0501 ns | 0.0027 ns |   0.5996 ns |   0.6048 ns |         - |
| TryParseCidrString | 3      | 214.8874 ns | 5.2161 ns | 0.2859 ns | 214.6546 ns | 215.2065 ns |         - |
| TryParseCidrBytes  | 3      |   9.0035 ns | 1.7353 ns | 0.0951 ns |   8.9243 ns |   9.1090 ns |         - |
