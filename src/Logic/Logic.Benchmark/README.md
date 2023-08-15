# Logic.Benchmark.StopwatchBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method |     Mean |   Error |  StdDev |      Min |      Max | Allocated |
|--------------- |---------:|--------:|--------:|---------:|---------:|----------:|
|      Stopwatch | 266.5 μs | 2.36 μs | 0.13 μs | 266.3 μs | 266.6 μs |      40 B |
| ValueStopwatch | 273.2 μs | 0.31 μs | 0.02 μs | 273.2 μs | 273.2 μs |         - |
# Logic.Benchmark.BinaryArrayConverterBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method |      Mean |     Error |    StdDev |       Min |       Max | Rank |  Gen 0 | Allocated |
|----------------------------- |----------:|----------:|----------:|----------:|----------:|-----:|-------:|----------:|
|             ToBinaryArrayInt |  6.434 μs | 1.1812 μs | 0.0647 μs |  6.392 μs |  6.509 μs |    1 | 0.3204 |      8 KB |
|    ToBinaryArrayIntModNumber |  7.137 μs | 0.5041 μs | 0.0276 μs |  7.114 μs |  7.168 μs |    2 | 0.3204 |      8 KB |
|          ToBinaryArrayIntMod |  7.227 μs | 2.4025 μs | 0.1317 μs |  7.140 μs |  7.379 μs |    3 | 0.3204 |      8 KB |
| ToBinaryArrayConvertToString | 25.798 μs | 1.4807 μs | 0.0812 μs | 25.730 μs | 25.888 μs |    4 | 0.9155 |     23 KB |
# Logic.Benchmark.ExponentialBackoffBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method |     Mean |    Error |  StdDev |      Min |      Max | Allocated |
|------------------- |---------:|---------:|--------:|---------:|---------:|----------:|
| ExponentialBackoff | 756.6 ms | 60.67 ms | 3.33 ms | 754.6 ms | 760.4 ms |      5 KB |
# Logic.Benchmark.StringSplitBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method |     Mean |    Error |   StdDev |      Min |      Max | Rank |     Gen 0 |    Allocated |
|------------------- |---------:|---------:|---------:|---------:|---------:|-----:|----------:|-------------:|
| StringSplitNoAlloc | 18.06 ms | 0.405 ms | 0.022 ms | 18.04 ms | 18.08 ms |    1 |         - |         26 B |
|        StringSplit | 20.39 ms | 0.177 ms | 0.010 ms | 20.38 ms | 20.40 ms |    2 | 1250.0000 | 32,080,026 B |
# Logic.Benchmark.StringReverseBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                 Method |        Mean |      Error |   StdDev |         Min |         Max | Rank |     Gen 0 | Allocated |
|----------------------- |------------:|-----------:|---------:|------------:|------------:|-----:|----------:|----------:|
|             StringSpan |    535.5 μs |   141.3 μs |  7.74 μs |    527.0 μs |    542.1 μs |    1 |   60.5469 |      1 MB |
|           ArrayReverse |    714.4 μs |   127.6 μs |  6.99 μs |    706.5 μs |    720.0 μs |    2 |  121.0938 |      3 MB |
|             ReverseXor |  1,296.7 μs |   483.3 μs | 26.49 μs |  1,268.8 μs |  1,321.5 μs |    3 |  121.0938 |      3 MB |
|           StackReverse |  6,062.4 μs | 1,193.7 μs | 65.43 μs |  6,004.9 μs |  6,133.6 μs |    4 |  351.5625 |      9 MB |
| StringExtensionReverse |  7,755.2 μs |   337.4 μs | 18.49 μs |  7,737.4 μs |  7,774.3 μs |    5 |  273.4375 |      7 MB |
|      EnumerableReverse | 11,275.2 μs |   565.3 μs | 30.99 μs | 11,241.0 μs | 11,301.4 μs |    6 |  234.3750 |      6 MB |
|       RecursiveReverse | 22,978.8 μs |   423.7 μs | 23.22 μs | 22,955.3 μs | 23,001.7 μs |    7 | 2875.0000 |     69 MB |
# Logic.Benchmark.Networks.CidrBlockBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method |        Mean |     Error |   StdDev |         Min |         Max | Allocated |
|------------------------ |------------:|----------:|---------:|------------:|------------:|----------:|
|      CidrBlockNewString | 16,470.5 ns | 475.88 ns | 26.08 ns | 16,453.3 ns | 16,500.5 ns |         - |
|       CidrBlockNewBytes |    257.7 ns |  15.64 ns |  0.86 ns |    256.7 ns |    258.3 ns |         - |
| CidrBlockTryParseString | 17,048.0 ns |  75.34 ns |  4.13 ns | 17,043.3 ns | 17,051.1 ns |         - |
|  CidrBlockTryParseBytes |  1,428.9 ns |   4.91 ns |  0.27 ns |  1,428.6 ns |  1,429.1 ns |         - |
# Logic.Benchmark.Networks.SubnetMaskBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                      Method |      Mean |     Error |    StdDev |       Min |       Max |  Gen 0 | Allocated |
|---------------------------- |----------:|----------:|----------:|----------:|----------:|-------:|----------:|
|    SubnetMaskFromCidrNotion |  2.621 μs | 0.8291 μs | 0.0454 μs |  2.592 μs |  2.673 μs | 0.2213 |      5 KB |
|   SubnetMaskFromCidrAddress | 18.880 μs | 0.9938 μs | 0.0545 μs | 18.818 μs | 18.921 μs | 0.4272 |     11 KB |
|  SubnetMaskFromCidrAddress2 | 18.528 μs | 1.1151 μs | 0.0611 μs | 18.475 μs | 18.595 μs | 0.4272 |     11 KB |
|     SubnetMaskFromIPAddress | 14.428 μs | 0.1911 μs | 0.0105 μs | 14.416 μs | 14.434 μs | 0.2136 |      5 KB |
| SubnetMaskGetNetworkAddress |  7.898 μs | 0.4005 μs | 0.0220 μs |  7.884 μs |  7.923 μs | 0.2136 |      5 KB |
|   SubnetMaskGetAddressRange | 20.498 μs | 0.7019 μs | 0.0385 μs | 20.454 μs | 20.528 μs | 0.6409 |     16 KB |
# Logic.Benchmark.ValueTaskDelayBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method |    Mean |    Error |   StdDev |     Min |     Max | Allocated |
|--------------- |--------:|---------:|---------:|--------:|--------:|----------:|
|      TaskDelay | 1.219 s | 0.1374 s | 0.0075 s | 1.212 s | 1.227 s |     21 KB |
| ValueTaskDelay | 1.010 s | 0.0117 s | 0.0006 s | 1.009 s | 1.010 s |      1 KB |
