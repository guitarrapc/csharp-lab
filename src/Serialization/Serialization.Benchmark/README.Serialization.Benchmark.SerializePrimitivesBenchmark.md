```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 991.69 ns | 58.288 ns | 3.195 ns | 988.21 ns | 994.49 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 940.92 ns | 30.302 ns | 1.661 ns | 939.32 ns | 942.64 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  97.25 ns |  2.284 ns | 0.125 ns |  97.13 ns |  97.38 ns | 0.0014 |     120 B |
