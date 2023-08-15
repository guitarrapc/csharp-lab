# MemoryLeak.Benchmark.NoAllocMemoryLeakBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|            Method |  N |       Mean |     Error |   StdDev | Allocated |
|------------------ |--- |-----------:|----------:|---------:|----------:|
|        RentReturn | 10 |   893.6 ns | 207.59 ns | 11.38 ns |         - |
| AllocateArrayPool | 10 | 1,343.3 ns |   1.10 ns |  0.06 ns |         - |
# MemoryLeak.Benchmark.MemoryLeakBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|               Method |  N |      Mean |      Error |    StdDev |    Median |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|--------------------- |--- |----------:|-----------:|----------:|----------:|-------:|-------:|-------:|----------:|
| AllocateStringStatic | 10 | 13.736 μs | 122.228 μs | 6.6997 μs | 10.464 μs | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|       AllocateString | 10 |  9.343 μs |   4.744 μs | 0.2600 μs |  9.250 μs | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|          AllocateLoH | 10 |  8.917 μs |   7.587 μs | 0.4159 μs |  9.036 μs | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|        AllocateArray | 10 |  8.872 μs |   7.725 μs | 0.4234 μs |  8.644 μs | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|    AllocateArrayPool | 10 |  9.168 μs |   5.087 μs | 0.2788 μs |  9.010 μs | 0.5646 | 0.5493 | 0.0153 |     10 KB |
