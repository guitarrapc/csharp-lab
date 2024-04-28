```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,021.44 ns | 83.669 ns | 4.586 ns | 1,018.66 ns | 1,026.74 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   913.27 ns | 18.715 ns | 1.026 ns |   912.48 ns |   914.43 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    97.50 ns |  3.075 ns | 0.169 ns |    97.38 ns |    97.69 ns | 0.0014 |     120 B |
