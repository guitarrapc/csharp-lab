```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,005.90 ns | 111.541 ns | 6.114 ns | 1,000.25 ns | 1,012.39 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   939.45 ns |  52.049 ns | 2.853 ns |   937.24 ns |   942.67 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.58 ns |   6.454 ns | 0.354 ns |    94.33 ns |    94.98 ns | 0.0014 |     120 B |
