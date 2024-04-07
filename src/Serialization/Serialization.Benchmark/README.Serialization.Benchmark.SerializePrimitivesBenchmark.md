```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 976.73 ns | 12.882 ns | 0.706 ns | 975.93 ns | 977.26 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 904.97 ns | 68.077 ns | 3.732 ns | 900.81 ns | 908.01 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  92.35 ns |  0.728 ns | 0.040 ns |  92.32 ns |  92.40 ns | 0.0014 |     120 B |
