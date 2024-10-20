```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   889.2 ns |   6.95 ns |  0.38 ns |   888.8 ns |   889.6 ns |      - |         - |
| StringSplit        | 1      | 1,609.1 ns | 288.16 ns | 15.80 ns | 1,598.7 ns | 1,627.3 ns | 0.0381 |    3208 B |
