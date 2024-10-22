```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 630.98 ns | 11.304 ns | 0.620 ns | 630.45 ns | 631.66 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 688.81 ns | 24.593 ns | 1.348 ns | 687.89 ns | 690.36 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.88 ns |  0.915 ns | 0.050 ns |  59.85 ns |  59.94 ns | 0.0014 |     120 B |
