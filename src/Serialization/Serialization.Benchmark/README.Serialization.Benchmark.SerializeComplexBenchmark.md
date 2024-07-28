```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 732.51 ns | 189.838 ns | 10.406 ns | 722.43 ns | 743.21 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 792.85 ns |  19.501 ns |  1.069 ns | 791.69 ns | 793.79 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  65.94 ns |   4.165 ns |  0.228 ns |  65.79 ns |  66.20 ns | 0.0014 |     120 B |
