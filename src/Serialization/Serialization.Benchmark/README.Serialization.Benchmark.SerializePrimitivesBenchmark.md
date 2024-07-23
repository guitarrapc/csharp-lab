```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 987.62 ns | 144.384 ns | 7.914 ns | 982.05 ns | 996.68 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 909.04 ns |  13.516 ns | 0.741 ns | 908.26 ns | 909.73 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  95.93 ns |   3.696 ns | 0.203 ns |  95.72 ns |  96.12 ns | 0.0014 |     120 B |
