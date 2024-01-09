```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method             | Number | Mean     | Error     | StdDev    | Min      | Max      | Allocated |
|------------------- |------- |---------:|----------:|----------:|---------:|---------:|----------:|
| CompositeFormat    | 100    | 36.60 μs | 120.47 μs |  6.603 μs | 32.77 μs | 44.22 μs |     14 KB |
| StringFormat       | 100    | 53.40 μs | 225.10 μs | 12.339 μs | 46.26 μs | 67.65 μs |  16.34 KB |
| InterpolatedFormat | 100    | 41.97 μs |  18.06 μs |  0.990 μs | 40.83 μs | 42.62 μs |     14 KB |
