```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 984.91 ns | 66.334 ns | 3.636 ns | 980.73 ns | 987.38 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 901.49 ns | 13.650 ns | 0.748 ns | 900.64 ns | 902.05 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  91.48 ns |  1.759 ns | 0.096 ns |  91.40 ns |  91.58 ns | 0.0014 |     120 B |
