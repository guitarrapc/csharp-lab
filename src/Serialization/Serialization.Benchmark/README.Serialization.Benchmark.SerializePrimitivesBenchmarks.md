```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,021.93 ns | 19.140 ns | 1.049 ns | 1,020.97 ns | 1,023.05 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   905.76 ns | 10.661 ns | 0.584 ns |   905.11 ns |   906.24 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.91 ns |  5.809 ns | 0.318 ns |    92.56 ns |    93.19 ns | 0.0014 |     120 B |
