```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error    | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|---------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,008.50 ns | 3.562 ns | 0.195 ns | 1,008.29 ns | 1,008.68 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   903.95 ns | 7.124 ns | 0.391 ns |   903.62 ns |   904.38 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    91.81 ns | 1.720 ns | 0.094 ns |    91.71 ns |    91.90 ns | 0.0014 |     120 B |
