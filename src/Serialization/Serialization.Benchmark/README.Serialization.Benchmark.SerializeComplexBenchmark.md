```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 647.17 ns |  20.336 ns | 1.115 ns | 646.29 ns | 648.42 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 686.85 ns | 119.523 ns | 6.551 ns | 682.25 ns | 694.35 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.81 ns |   4.364 ns | 0.239 ns |  59.60 ns |  60.07 ns | 0.0014 |     120 B |
