```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean       | Error     | StdDev  | Min        | Max        | Gen0   | Allocated |
|------------------- |------- |-----------:|----------:|--------:|-----------:|-----------:|-------:|----------:|
| StringSplitNoAlloc | 1      |   829.7 ns |  15.21 ns | 0.83 ns |   828.9 ns |   830.6 ns |      - |         - |
| StringSplit        | 1      | 1,517.9 ns | 155.42 ns | 8.52 ns | 1,512.0 ns | 1,527.7 ns | 0.0381 |    3208 B |
