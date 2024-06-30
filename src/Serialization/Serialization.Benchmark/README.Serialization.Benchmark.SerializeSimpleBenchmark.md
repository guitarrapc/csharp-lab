```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error   | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|--------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 440.1 ns | 1.50 ns | 0.08 ns | 440.1 ns | 440.2 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 337.6 ns | 3.58 ns | 0.20 ns | 337.4 ns | 337.8 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 101.7 ns | 4.68 ns | 0.26 ns | 101.5 ns | 102.0 ns | 0.0014 |     128 B |
