```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,013.23 ns | 14.888 ns | 0.816 ns | 1,012.35 ns | 1,013.96 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   918.98 ns | 22.754 ns | 1.247 ns |   918.15 ns |   920.42 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.18 ns |  7.020 ns | 0.385 ns |    93.79 ns |    94.55 ns | 0.0014 |     120 B |
