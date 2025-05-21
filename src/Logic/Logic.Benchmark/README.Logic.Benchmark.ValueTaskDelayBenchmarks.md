```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|--------------- |--------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| TaskDelay      | .NET 8.0 | 1      | 10.29 ms | 1.012 ms | 0.055 ms | 10.23 ms | 10.34 ms |     352 B |
| ValueTaskDelay | .NET 8.0 | 1      | 10.16 ms | 0.272 ms | 0.015 ms | 10.15 ms | 10.18 ms |     128 B |
| TaskDelay      | .NET 9.0 | 1      | 10.17 ms | 0.418 ms | 0.023 ms | 10.15 ms | 10.20 ms |     352 B |
| ValueTaskDelay | .NET 9.0 | 1      | 10.14 ms | 0.101 ms | 0.006 ms | 10.13 ms | 10.14 ms |     128 B |
