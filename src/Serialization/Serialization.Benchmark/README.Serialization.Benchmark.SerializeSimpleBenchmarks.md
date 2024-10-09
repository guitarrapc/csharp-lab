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
| SystemTextJson          | Seria(...)Class [26] | 440.7 ns | 170.19 ns | 9.33 ns | 433.4 ns | 451.2 ns | 0.0038 |     328 B |
| SystemTextJsonSourceGen | Seria(...)Class [26] | 340.9 ns |  28.41 ns | 1.56 ns | 339.9 ns | 342.7 ns | 0.0043 |     368 B |
| MemoryPack              | Seria(...)Class [26] | 105.9 ns |   1.97 ns | 0.11 ns | 105.9 ns | 106.1 ns | 0.0014 |     128 B |
