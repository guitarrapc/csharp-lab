```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method         | Runtime  | Number | Mean     | Error    | StdDev   | Min      | Max      | Allocated |
|--------------- |--------- |------- |---------:|---------:|---------:|---------:|---------:|----------:|
| TaskDelay      | .NET 8.0 | 1      | 10.25 ms | 0.418 ms | 0.023 ms | 10.23 ms | 10.28 ms |     352 B |
| ValueTaskDelay | .NET 8.0 | 1      | 10.14 ms | 0.301 ms | 0.017 ms | 10.13 ms | 10.16 ms |     128 B |
| TaskDelay      | .NET 9.0 | 1      | 10.24 ms | 0.189 ms | 0.010 ms | 10.24 ms | 10.26 ms |     352 B |
| ValueTaskDelay | .NET 9.0 | 1      | 10.18 ms | 0.022 ms | 0.001 ms | 10.17 ms | 10.18 ms |     128 B |
