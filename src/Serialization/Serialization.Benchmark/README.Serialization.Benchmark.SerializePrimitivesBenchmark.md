```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error    | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|---------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,030.43 ns | 8.380 ns | 0.459 ns | 1,029.94 ns | 1,030.85 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   922.84 ns | 5.841 ns | 0.320 ns |   922.49 ns |   923.13 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    92.75 ns | 3.165 ns | 0.173 ns |    92.55 ns |    92.87 ns | 0.0014 |     120 B |
