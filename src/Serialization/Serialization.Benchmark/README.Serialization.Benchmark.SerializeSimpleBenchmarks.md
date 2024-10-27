```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean     | Error     | StdDev  | Min      | Max      | Gen0   | Allocated |
|------------------------ |--------------------- |---------:|----------:|--------:|---------:|---------:|-------:|----------:|
| SystemTextJson          | Seria(...)Class [26] | 440.5 ns |  16.48 ns | 0.90 ns | 439.6 ns | 441.3 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 335.9 ns | 106.62 ns | 5.84 ns | 332.0 ns | 342.6 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 104.8 ns |   7.67 ns | 0.42 ns | 104.5 ns | 105.3 ns | 0.0014 |     128 B |
