```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 414.97 ns | 30.674 ns | 1.681 ns | 413.50 ns | 416.80 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 314.94 ns | 52.741 ns | 2.891 ns | 312.19 ns | 317.95 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  96.38 ns |  7.409 ns | 0.406 ns |  95.96 ns |  96.77 ns | 0.0014 |     128 B |
