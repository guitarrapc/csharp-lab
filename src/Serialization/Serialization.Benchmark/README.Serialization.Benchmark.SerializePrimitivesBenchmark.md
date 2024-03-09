```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 985.25 ns | 98.850 ns | 5.418 ns | 981.33 ns | 991.43 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 939.26 ns | 33.065 ns | 1.812 ns | 937.17 ns | 940.39 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  93.12 ns |  5.610 ns | 0.307 ns |  92.79 ns |  93.40 ns | 0.0014 |     120 B |
