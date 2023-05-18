# LoggerBenchmark

Environment

```
// * Summary *

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
AMD Ryzen 9 7950X3D, 1 CPU, 32 logical and 16 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT  [AttachedDebugger]
  ShortRun : .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3
```

## Benchmarks


|             Method |         Mean |         Error |       StdDev |          Min |          Max | Allocated |
|------------------- |-------------:|--------------:|-------------:|-------------:|-------------:|----------:|
|   StopwatchDefault |     149.1 us |       1.65 us |      0.09 us |     149.0 us |     149.2 us |      40 B |
|     StopwatchValue |     147.5 us |       5.53 us |      0.30 us |     147.2 us |     147.8 us |       3 B |
| ExponentialBackoff | 858,966.2 us | 673,895.68 us | 36,938.50 us | 836,852.8 us | 901,609.3 us |   4,288 B |
