```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 988.17 ns | 58.534 ns | 3.208 ns | 985.75 ns | 991.81 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 902.49 ns | 63.013 ns | 3.454 ns | 900.25 ns | 906.46 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  92.42 ns |  3.280 ns | 0.180 ns |  92.26 ns |  92.61 ns | 0.0014 |     120 B |
