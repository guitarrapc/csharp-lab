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
| SystemTextJson          | Seria(...)tives [29] | 987.52 ns | 15.854 ns | 0.869 ns | 986.59 ns | 988.32 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 931.14 ns | 30.998 ns | 1.699 ns | 929.99 ns | 933.09 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  93.68 ns |  5.546 ns | 0.304 ns |  93.46 ns |  94.03 ns | 0.0014 |     120 B |
