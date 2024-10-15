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
| SystemTextJson          | Seria(...)tives [29] | 1,039.34 ns | 22.571 ns | 1.237 ns | 1,038.52 ns | 1,040.76 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   904.92 ns | 28.331 ns | 1.553 ns |   904.00 ns |   906.71 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.37 ns |  3.360 ns | 0.184 ns |    94.15 ns |    94.47 ns | 0.0014 |     120 B |
