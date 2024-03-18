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
| SystemTextJson          | Seria(...)tives [29] | 1,007.51 ns | 72.430 ns | 3.970 ns | 1,003.84 ns | 1,011.72 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   922.31 ns | 10.224 ns | 0.560 ns |   921.68 ns |   922.75 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.03 ns |  3.332 ns | 0.183 ns |    93.92 ns |    94.24 ns | 0.0014 |     120 B |
