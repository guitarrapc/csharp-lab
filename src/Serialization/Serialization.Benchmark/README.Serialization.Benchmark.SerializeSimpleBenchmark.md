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
| SystemTextJson          | Seria(...)Class [26] | 411.38 ns |  8.310 ns | 0.456 ns | 410.94 ns | 411.85 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 324.51 ns | 18.030 ns | 0.988 ns | 323.61 ns | 325.57 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] |  99.66 ns |  2.536 ns | 0.139 ns |  99.51 ns |  99.78 ns | 0.0014 |     128 B |
