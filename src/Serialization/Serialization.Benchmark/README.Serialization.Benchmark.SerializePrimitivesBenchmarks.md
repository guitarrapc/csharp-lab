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
| SystemTextJson          | Seria(...)tives [29] | 993.83 ns | 94.555 ns | 5.183 ns | 989.38 ns | 999.52 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 914.21 ns | 17.585 ns | 0.964 ns | 913.30 ns | 915.22 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  93.15 ns |  0.465 ns | 0.025 ns |  93.12 ns |  93.17 ns | 0.0014 |     120 B |
