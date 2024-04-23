```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                  | data                 | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------ |--------------------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| SystemTextJson          | Seria(...)tives [29] | 1,005.01 ns | 112.168 ns | 6.148 ns | 1,001.32 ns | 1,012.11 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] |   935.86 ns |  66.891 ns | 3.667 ns |   932.53 ns |   939.79 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |    94.73 ns |   4.027 ns | 0.221 ns |    94.56 ns |    94.98 ns | 0.0014 |     120 B |
