``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method |  N |     Mean |     Error |    StdDev | Allocated |
|------------------ |--- |---------:|----------:|----------:|----------:|
|        RentReturn | 10 | 1.002 μs | 0.1032 μs | 0.0057 μs |         - |
| AllocateArrayPool | 10 | 1.609 μs | 0.9336 μs | 0.0512 μs |         - |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon CPU E5-2673 v4 2.30GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |  N |     Mean |      Error |   StdDev |   Median |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|--------------------- |--- |---------:|-----------:|---------:|---------:|-------:|-------:|-------:|----------:|
| AllocateStringStatic | 10 | 15.61 μs | 133.401 μs | 7.312 μs | 11.46 μs | 0.4120 | 0.3967 | 0.0153 |     10 KB |
|       AllocateString | 10 | 10.96 μs |   1.766 μs | 0.097 μs | 11.00 μs | 0.4120 | 0.3967 | 0.0153 |     10 KB |
|          AllocateLoH | 10 | 10.46 μs |   3.475 μs | 0.190 μs | 10.52 μs | 0.4120 | 0.3967 | 0.0153 |     10 KB |
|        AllocateArray | 10 | 10.81 μs |   3.825 μs | 0.210 μs | 10.75 μs | 0.4120 | 0.3967 | 0.0153 |     10 KB |
|    AllocateArrayPool | 10 | 10.65 μs |  14.019 μs | 0.768 μs | 11.03 μs | 0.4120 | 0.3967 | 0.0153 |     10 KB |
