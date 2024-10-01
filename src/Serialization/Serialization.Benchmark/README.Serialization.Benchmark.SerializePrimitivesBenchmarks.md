```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,017.82 ns | 55.669 ns | 3.051 ns | 1,015.68 ns | 1,021.31 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   927.65 ns | 86.537 ns | 4.743 ns |   924.62 ns |   933.12 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    93.35 ns |  0.785 ns | 0.043 ns |    93.31 ns |    93.40 ns | 0.0014 |     120 B |
