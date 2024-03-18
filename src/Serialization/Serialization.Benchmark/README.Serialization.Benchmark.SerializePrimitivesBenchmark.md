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
| SystemTextJson          | Seria(...)tives [29] | 1,010.01 ns | 56.814 ns | 3.114 ns | 1,008.12 ns | 1,013.60 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   938.64 ns | 71.526 ns | 3.921 ns |   935.89 ns |   943.13 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    96.51 ns |  2.281 ns | 0.125 ns |    96.38 ns |    96.62 ns | 0.0014 |     120 B |
