```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 990.90 ns | 29.187 ns | 1.600 ns | 989.10 ns | 992.16 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 914.80 ns | 52.098 ns | 2.856 ns | 911.75 ns | 917.40 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  94.73 ns |  2.520 ns | 0.138 ns |  94.57 ns |  94.82 ns | 0.0014 |     120 B |
