```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 433.67 ns | 22.982 ns | 1.260 ns | 432.48 ns | 435.0 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 341.19 ns | 52.934 ns | 2.901 ns | 339.47 ns | 344.5 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  99.96 ns |  5.607 ns | 0.307 ns |  99.76 ns | 100.3 ns | 0.0014 |     128 B |
