```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,017.12 ns | 35.038 ns | 1.921 ns | 1,015.31 ns | 1,019.14 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   918.83 ns | 77.572 ns | 4.252 ns |   915.64 ns |   923.65 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    93.03 ns |  1.308 ns | 0.072 ns |    92.95 ns |    93.09 ns | 0.0014 |     120 B |
