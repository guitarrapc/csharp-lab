```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 634.34 ns | 19.164 ns | 1.050 ns | 633.25 ns | 635.35 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 687.72 ns |  6.744 ns | 0.370 ns | 687.38 ns | 688.11 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  58.22 ns | 22.845 ns | 1.252 ns |  57.43 ns |  59.67 ns | 0.0014 |     120 B |
