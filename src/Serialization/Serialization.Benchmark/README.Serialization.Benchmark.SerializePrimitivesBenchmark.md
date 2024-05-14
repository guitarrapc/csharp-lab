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
| SystemTextJson          | Seria(...)tives [29] | 994.29 ns | 14.132 ns | 0.775 ns | 993.69 ns | 995.16 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 917.92 ns | 40.953 ns | 2.245 ns | 915.33 ns | 919.35 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  96.83 ns |  6.252 ns | 0.343 ns |  96.50 ns |  97.19 ns | 0.0014 |     120 B |
