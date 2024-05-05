```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|------------------------ |--------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 995.00 ns | 77.853 ns | 4.267 ns | 990.10 ns | 997.86 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 935.56 ns | 16.343 ns | 0.896 ns | 934.53 ns | 936.16 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  95.11 ns |  2.883 ns | 0.158 ns |  95.01 ns |  95.29 ns | 0.0014 |     120 B |
