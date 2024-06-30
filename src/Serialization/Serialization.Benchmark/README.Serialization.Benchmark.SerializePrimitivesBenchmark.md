```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,015.86 ns | 82.822 ns | 4.540 ns | 1,011.01 ns | 1,020.00 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   924.42 ns | 11.694 ns | 0.641 ns |   923.71 ns |   924.95 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.18 ns |  4.143 ns | 0.227 ns |    94.97 ns |    95.43 ns | 0.0014 |     120 B |
