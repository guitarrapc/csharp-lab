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
| SystemTextJson          | Seria(...)tives [29] | 1,017.74 ns | 26.161 ns | 1.434 ns | 1,016.82 ns | 1,019.39 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   923.24 ns | 21.750 ns | 1.192 ns |   921.88 ns |   924.10 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.33 ns |  3.635 ns | 0.199 ns |    95.16 ns |    95.55 ns | 0.0014 |     120 B |
