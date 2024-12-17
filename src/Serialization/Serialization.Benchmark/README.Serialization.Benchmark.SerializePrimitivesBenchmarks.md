```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 974.31 ns | 38.266 ns | 2.098 ns | 972.77 ns | 976.70 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 877.23 ns | 34.795 ns | 1.907 ns | 875.71 ns | 879.37 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  81.48 ns |  1.590 ns | 0.087 ns |  81.39 ns |  81.56 ns | 0.0014 |     120 B |
