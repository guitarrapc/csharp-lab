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
| SystemTextJson          | Seria(...)tives [29] | 996.98 ns | 93.890 ns | 5.146 ns | 993.76 ns | 1,002.91 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 918.17 ns | 31.248 ns | 1.713 ns | 916.49 ns |   919.92 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  92.84 ns |  2.369 ns | 0.130 ns |  92.70 ns |    92.95 ns | 0.0014 |     120 B |
