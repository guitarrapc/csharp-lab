```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 641.75 ns | 78.944 ns | 4.327 ns | 637.98 ns | 646.48 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 700.43 ns |  8.143 ns | 0.446 ns | 700.01 ns | 700.90 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.36 ns |  2.569 ns | 0.141 ns |  58.23 ns |  58.51 ns | 0.0014 |     120 B |
