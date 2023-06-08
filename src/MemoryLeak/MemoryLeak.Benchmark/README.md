# MemoryLeak.Benchmark

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|               Method |  N |      Mean |       Error |    StdDev |    Median |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|--------------------- |--- |----------:|------------:|----------:|----------:|-------:|-------:|-------:|----------:|
| AllocateStringStatic | 10 | 142.32 μs | 1,261.58 μs | 69.151 μs | 117.54 μs | 5.4932 | 5.3711 | 0.1221 |    100 KB |
|       AllocateString | 10 | 127.09 μs | 1,216.49 μs | 66.680 μs |  91.40 μs | 5.4932 | 5.3711 | 0.1221 |    100 KB |
|          AllocateLoH | 10 | 112.93 μs | 1,061.88 μs | 58.205 μs |  79.86 μs | 5.4932 | 5.3711 | 0.1221 |    100 KB |
|        AllocateArray | 10 | 108.79 μs |   913.58 μs | 50.076 μs |  80.16 μs | 5.4932 | 5.3711 | 0.1221 |    100 KB |
|    AllocateArrayPool | 10 |  55.24 μs |    15.61 μs |  0.855 μs |  55.41 μs | 5.3711 | 5.2490 |      - |    100 KB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.302
  [Host]   : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT
  ShortRun : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|            Method |  N |     Mean |     Error |    StdDev | Allocated |
|------------------ |--- |---------:|----------:|----------:|----------:|
|        RentReturn | 10 | 1.047 μs | 0.0040 μs | 0.0002 μs |         - |
| AllocateArrayPool | 10 | 3.029 μs | 0.0055 μs | 0.0003 μs |         - |
