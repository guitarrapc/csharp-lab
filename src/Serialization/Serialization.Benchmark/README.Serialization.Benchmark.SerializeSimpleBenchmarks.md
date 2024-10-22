```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev   | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|---------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 435.2 ns | 262.16 ns | 14.37 ns | 426.0 ns | 451.7 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 348.9 ns |  26.96 ns |  1.48 ns | 347.7 ns | 350.6 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 100.6 ns |   1.76 ns |  0.10 ns | 100.5 ns | 100.6 ns | 0.0014 |     128 B |
