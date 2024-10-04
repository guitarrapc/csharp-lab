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
| SystemTextJson          | Seria(...)tives [29] | 1,014.93 ns | 35.666 ns | 1.955 ns | 1,013.37 ns | 1,017.12 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   932.89 ns | 27.611 ns | 1.513 ns |   931.65 ns |   934.58 ns | 0.0057 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    95.59 ns |  2.893 ns | 0.159 ns |    95.42 ns |    95.73 ns | 0.0014 |     120 B |
