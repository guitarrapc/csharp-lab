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
| SystemTextJson          | Seria(...)tives [29] | 992.67 ns | 52.045 ns | 2.853 ns | 990.96 ns | 995.96 ns | 0.0038 |     464 B |
| SystemTextJsonSourceGen | Seria(...)tives [29] | 910.64 ns | 42.597 ns | 2.335 ns | 909.03 ns | 913.32 ns | 0.0067 |     568 B |
| MemoryPack              | Seria(...)tives [29] |  92.90 ns |  6.546 ns | 0.359 ns |  92.49 ns |  93.18 ns | 0.0014 |     120 B |
