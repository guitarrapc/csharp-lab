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
| SystemTextJson          | Seria(...)Class [29] | 635.69 ns | 13.100 ns | 0.718 ns | 634.90 ns | 636.30 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 691.81 ns | 32.696 ns | 1.792 ns | 690.26 ns | 693.77 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  57.81 ns |  1.825 ns | 0.100 ns |  57.74 ns |  57.92 ns | 0.0014 |     120 B |
