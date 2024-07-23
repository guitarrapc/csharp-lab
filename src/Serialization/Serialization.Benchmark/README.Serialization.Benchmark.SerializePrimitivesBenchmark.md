```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 998.38 ns | 41.446 ns | 2.272 ns | 996.84 ns | 1,000.99 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 961.68 ns | 48.570 ns | 2.662 ns | 958.61 ns |   963.38 ns | 0.0057 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  96.03 ns |  1.197 ns | 0.066 ns |  95.97 ns |    96.10 ns | 0.0014 |     120 B |
