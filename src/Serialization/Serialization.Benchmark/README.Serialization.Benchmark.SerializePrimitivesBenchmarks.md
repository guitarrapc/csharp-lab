```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev   | Min       | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|---------:|----------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,001.24 ns | 149.490 ns | 8.194 ns | 995.34 ns | 1,010.60 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   926.42 ns |  39.200 ns | 2.149 ns | 923.96 ns |   927.92 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    96.99 ns |   5.052 ns | 0.277 ns |  96.73 ns |    97.28 ns | 0.0014 |     120 B |
