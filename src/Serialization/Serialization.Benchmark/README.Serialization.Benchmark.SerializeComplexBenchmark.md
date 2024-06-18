```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [29] | 637.52 ns | 16.899 ns | 0.926 ns | 636.46 ns | 638.14 ns | 0.0038 |     392 B |
| SystemTextJsonSourceGen | Seria(...)Class [29] | 719.66 ns | 26.409 ns | 1.448 ns | 718.68 ns | 721.33 ns | 0.0048 |     464 B |
| MemoryPack              | Seria(...)Class [29] |  60.87 ns |  2.698 ns | 0.148 ns |  60.71 ns |  61.00 ns | 0.0014 |     120 B |
