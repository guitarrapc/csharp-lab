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
| SystemTextJson          | Seria(...)tives [29] | 1,012.41 ns | 87.036 ns | 4.771 ns | 1,008.88 ns | 1,017.84 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   941.56 ns | 10.900 ns | 0.597 ns |   941.01 ns |   942.19 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    99.58 ns |  2.685 ns | 0.147 ns |    99.46 ns |    99.75 ns | 0.0014 |     120 B |
