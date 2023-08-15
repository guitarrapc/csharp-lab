# LogicLab.Benchmark

## benchmark (Logger.Benchmark, ./src/Logger/Logger.Benchmark/Logger.Benchmark.csproj) summary

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon CPU E5-2673 v3 2.40GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|                                     Method |      Mean |     Error |   StdDev |       Min |       Max |  Gen 0 | Allocated |
|------------------------------------------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
|                         LogWithoutIfParams | 170.58 ns | 51.687 ns | 2.833 ns | 168.76 ns | 173.85 ns | 0.0055 |      88 B |
|                            LogWithIfParams | 175.62 ns | 10.842 ns | 0.594 ns | 175.05 ns | 176.23 ns | 0.0055 |      88 B |
|                  LogAdapterWithoutIfParams | 183.03 ns | 36.758 ns | 2.015 ns | 181.63 ns | 185.34 ns | 0.0055 |      88 B |
|                   LogDefineWithoutIfParams |  40.06 ns | 10.206 ns | 0.559 ns |  39.64 ns |  40.69 ns |      - |         - |
|                LogSourceGenWithoutIfParams |  36.48 ns |  3.841 ns | 0.211 ns |  36.24 ns |  36.65 ns |      - |         - |
| LogSourceGenSkipEnableCheckWithoutIfParams |  31.51 ns |  6.185 ns | 0.339 ns |  31.21 ns |  31.88 ns |      - |         - |


## benchmark (Logic.Benchmark, ./src/Logic/LogicLab.Benchmark/LogicLab.Benchmark.csproj) summary
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|         Method |        Mean |       Error |    StdDev |         Min |         Max | Allocated |
|--------------- |------------:|------------:|----------:|------------:|------------:|----------:|
|     CtorString | 19,150.5 ns | 4,798.50 ns | 263.02 ns | 18,931.3 ns | 19,442.1 ns |         - |
|      CtorBytes |    306.5 ns |    75.58 ns |   4.14 ns |    303.0 ns |    311.1 ns |         - |
| TryParseString | 20,075.4 ns | 9,432.01 ns | 517.00 ns | 19,633.0 ns | 20,643.8 ns |         - |
|  TryParseBytes |  1,568.9 ns |   571.02 ns |  31.30 ns |  1,541.1 ns |  1,602.8 ns |         - |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|         Method |    Mean |    Error |   StdDev |     Min |     Max | Allocated |
|--------------- |--------:|---------:|---------:|--------:|--------:|----------:|
|      TaskDelay | 1.201 s | 0.0130 s | 0.0007 s | 1.200 s | 1.201 s |     22 KB |
| ValueTaskDelay | 1.018 s | 0.0140 s | 0.0008 s | 1.017 s | 1.018 s |      1 KB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|             Method |     Mean |    Error |  StdDev |      Min |      Max | Allocated |
|------------------- |---------:|---------:|--------:|---------:|---------:|----------:|
| ExponentialBackoff | 754.0 ms | 13.09 ms | 0.72 ms | 753.5 ms | 754.8 ms |      5 KB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|                       Method |     Mean |    Error |   StdDev |      Min |      Max | Rank |  Gen 0 | Allocated |
|----------------------------- |---------:|---------:|---------:|---------:|---------:|-----:|-------:|----------:|
|             ToBinaryArrayInt | 10.51 μs | 7.539 μs | 0.413 μs | 10.06 μs | 10.87 μs |    1 | 0.4272 |      8 KB |
|    ToBinaryArrayIntModNumber | 11.27 μs | 6.822 μs | 0.374 μs | 10.96 μs | 11.68 μs |    2 | 0.4272 |      8 KB |
|          ToBinaryArrayIntMod | 11.53 μs | 5.324 μs | 0.292 μs | 11.24 μs | 11.83 μs |    3 | 0.4272 |      8 KB |
| ToBinaryArrayConvertToString | 45.02 μs | 3.898 μs | 0.214 μs | 44.89 μs | 45.26 μs |    4 | 1.2207 |     23 KB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|            Method |      Mean |      Error |    StdDev |       Min |       Max |  Gen 0 | Allocated |
|------------------ |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
|    FromCidrNotion |  2.880 μs |  0.9672 μs | 0.0530 μs |  2.844 μs |  2.941 μs | 0.2975 |      5 KB |
|   FromCidrAddress | 25.304 μs | 10.4347 μs | 0.5720 μs | 24.668 μs | 25.775 μs | 0.5798 |     11 KB |
|  FromCidrAddress2 | 24.925 μs | 16.3232 μs | 0.8947 μs | 23.899 μs | 25.541 μs | 0.5798 |     11 KB |
|     FromIPAddress | 21.287 μs |  5.5114 μs | 0.3021 μs | 21.006 μs | 21.606 μs | 0.2747 |      5 KB |
| GetNetworkAddress |  9.992 μs |  2.2108 μs | 0.1212 μs |  9.857 μs | 10.093 μs | 0.2899 |      5 KB |
|   GetAddressRange | 26.898 μs | 11.3512 μs | 0.6222 μs | 26.185 μs | 27.330 μs | 0.8850 |     16 KB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|       Method |     Mean |     Error |   StdDev |      Min |      Max | Rank |     Gen 0 |    Allocated |
|------------- |---------:|----------:|---------:|---------:|---------:|-----:|----------:|-------------:|
| SplitNoAlloc | 20.24 ms |  2.538 ms | 0.139 ms | 20.14 ms | 20.40 ms |    1 |         - |         26 B |
|        Split | 29.78 ms | 31.809 ms | 1.744 ms | 27.84 ms | 31.21 ms |    2 | 1687.5000 | 32,080,026 B |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|         Method |     Mean |     Error |  StdDev |      Min |      Max | Allocated |
|--------------- |---------:|----------:|--------:|---------:|---------:|----------:|
|      Stopwatch | 288.0 μs |  42.21 μs | 2.31 μs | 285.4 μs | 289.9 μs |      40 B |
| ValueStopwatch | 297.6 μs | 148.29 μs | 8.13 μs | 289.6 μs | 305.9 μs |         - |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8171M CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|                 Method |        Mean |       Error |      StdDev |         Min |         Max | Rank |     Gen 0 | Allocated |
|----------------------- |------------:|------------:|------------:|------------:|------------:|-----:|----------:|----------:|
|             StringSpan |    625.7 μs |    286.1 μs |    15.68 μs |    611.7 μs |    642.7 μs |    1 |   81.0547 |      1 MB |
|     ArrayReverseString |    926.2 μs |    690.5 μs |    37.85 μs |    900.5 μs |    969.6 μs |    2 |  162.1094 |      3 MB |
|             ReverseXor |  1,298.6 μs |    627.8 μs |    34.41 μs |  1,267.5 μs |  1,335.6 μs |    3 |  162.1094 |      3 MB |
|           StackReverse |  7,585.8 μs |  2,624.3 μs |   143.85 μs |  7,485.9 μs |  7,750.6 μs |    4 |  476.5625 |      9 MB |
| StringExtensionReverse |  9,486.3 μs |  7,332.7 μs |   401.93 μs |  9,186.0 μs |  9,942.9 μs |    5 |  359.3750 |      7 MB |
|      EnumerableReverse | 15,435.9 μs |  8,533.4 μs |   467.75 μs | 14,929.8 μs | 15,852.3 μs |    6 |  312.5000 |      6 MB |
| RecursiveStringReverse | 32,961.9 μs | 27,495.2 μs | 1,507.10 μs | 32,084.9 μs | 34,702.1 μs |    7 | 3875.0000 |     69 MB |

## benchmark (MemoryLeak.Benchmark, ./src/MemoryLeak/MemoryLeak.Benchmark/MemoryLeak.Benchmark.csproj) summary

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|            Method |  N |       Mean |    Error |  StdDev | Allocated |
|------------------ |--- |-----------:|---------:|--------:|----------:|
|        RentReturn | 10 |   865.4 ns | 12.34 ns | 0.68 ns |         - |
| AllocateArrayPool | 10 | 1,333.5 ns |  5.69 ns | 0.31 ns |         - |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT
  ShortRun : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1
WarmupCount=3

```
|               Method |  N |      Mean |     Error |    StdDev |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|--------------------- |--- |----------:|----------:|----------:|-------:|-------:|-------:|----------:|
| AllocateStringStatic | 10 | 11.576 μs | 47.295 μs | 2.5924 μs | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|       AllocateString | 10 |  9.306 μs |  3.527 μs | 0.1934 μs | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|          AllocateLoH | 10 |  9.069 μs |  6.466 μs | 0.3544 μs | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|        AllocateArray | 10 |  8.954 μs |  7.246 μs | 0.3972 μs | 0.5646 | 0.5493 | 0.0153 |     10 KB |
|    AllocateArrayPool | 10 |  9.246 μs |  5.578 μs | 0.3057 μs | 0.5646 | 0.5493 | 0.0153 |     10 KB |
