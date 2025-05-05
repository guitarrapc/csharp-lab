```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean       | Error     | StdDev   | Min        | Max        | Gen0   | Gen1   | Allocated |
|------------------- |--------- |------- |-----------:|----------:|---------:|-----------:|-----------:|-------:|-------:|----------:|
| StringSplitNoAlloc | .NET 8.0 | 1      |   852.1 ns | 374.85 ns | 20.55 ns |   839.5 ns |   875.8 ns |      - |      - |         - |
| StringSplit        | .NET 8.0 | 1      | 1,445.1 ns | 591.79 ns | 32.44 ns | 1,407.7 ns | 1,464.6 ns | 0.1907 | 0.0019 |    3208 B |
| StringSplitNoAlloc | .NET 9.0 | 1      |   850.6 ns |  49.31 ns |  2.70 ns |   847.6 ns |   852.9 ns |      - |      - |         - |
| StringSplit        | .NET 9.0 | 1      | 1,773.9 ns | 523.33 ns | 28.69 ns | 1,750.4 ns | 1,805.8 ns | 0.1907 | 0.0019 |    3208 B |
