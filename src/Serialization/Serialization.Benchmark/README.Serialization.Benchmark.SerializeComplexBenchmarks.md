```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 655.87 ns |  6.283 ns | 0.344 ns | 655.52 ns | 656.21 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 696.61 ns | 12.644 ns | 0.693 ns | 695.83 ns | 697.14 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  59.91 ns |  5.362 ns | 0.294 ns |  59.70 ns |  60.25 ns | 0.0014 |     120 B |
