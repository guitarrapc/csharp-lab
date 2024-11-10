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
| SystemTextJson          | Seria(...)Class [29] | 647.82 ns | 18.313 ns | 1.004 ns | 646.80 ns | 648.81 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 685.57 ns | 11.959 ns | 0.656 ns | 685.07 ns | 686.31 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.55 ns |  9.806 ns | 0.538 ns |  58.16 ns |  59.17 ns | 0.0014 |     120 B |
