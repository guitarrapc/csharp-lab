```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,002.63 ns | 11.318 ns | 0.620 ns | 1,001.93 ns | 1,003.12 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   925.53 ns | 19.355 ns | 1.061 ns |   924.44 ns |   926.56 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.98 ns |  3.299 ns | 0.181 ns |    95.79 ns |    96.15 ns | 0.0014 |     120 B |
