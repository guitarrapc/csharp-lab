```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 988.21 ns | 11.539 ns | 0.633 ns | 987.50 ns | 988.73 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 925.46 ns | 15.136 ns | 0.830 ns | 924.97 ns | 926.42 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  92.33 ns |  5.328 ns | 0.292 ns |  91.99 ns |  92.52 ns | 0.0014 |     120 B |
