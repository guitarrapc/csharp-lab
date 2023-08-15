``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method |     Mean |   Error |  StdDev |      Min |      Max | Allocated |
|--------------- |---------:|--------:|--------:|---------:|---------:|----------:|
|      Stopwatch | 274.2 μs | 0.69 μs | 0.04 μs | 274.2 μs | 274.3 μs |      46 B |
| ValueStopwatch | 280.9 μs | 3.11 μs | 0.17 μs | 280.8 μs | 281.1 μs |         - |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                                  Method |     Mean |    Error |   StdDev |      Min |      Max | Rank |  Gen 0 | Allocated |
|---------------------------------------- |---------:|---------:|---------:|---------:|---------:|-----:|-------:|----------:|
|             BinaryArrayToBinaryArrayInt | 10.08 μs | 0.128 μs | 0.007 μs | 10.07 μs | 10.09 μs |    1 | 0.4272 |      8 KB |
|    BinaryArrayToBinaryArrayIntModNumber | 10.44 μs | 0.157 μs | 0.009 μs | 10.43 μs | 10.44 μs |    2 | 0.4272 |      8 KB |
|          BinaryArrayToBinaryArrayIntMod | 11.13 μs | 1.399 μs | 0.077 μs | 11.08 μs | 11.22 μs |    3 | 0.4272 |      8 KB |
| BinaryArrayToBinaryArrayConvertToString | 38.89 μs | 0.670 μs | 0.037 μs | 38.85 μs | 38.93 μs |    4 | 1.2207 |     23 KB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method |     Mean |   Error |  StdDev |      Min |      Max | Allocated |
|------------------- |---------:|--------:|--------:|---------:|---------:|----------:|
| ExponentialBackoff | 757.5 ms | 4.09 ms | 0.22 ms | 757.4 ms | 757.8 ms |      5 KB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method |     Mean |    Error |   StdDev |      Min |      Max | Rank |     Gen 0 |    Allocated |
|------------------- |---------:|---------:|---------:|---------:|---------:|-----:|----------:|-------------:|
| StringSplitNoAlloc | 19.29 ms | 0.119 ms | 0.007 ms | 19.28 ms | 19.29 ms |    1 |         - |         26 B |
|        StringSplit | 28.53 ms | 0.983 ms | 0.054 ms | 28.46 ms | 28.56 ms |    2 | 1687.5000 | 32,080,026 B |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                 Method |        Mean |        Error |    StdDev |         Min |         Max | Rank |     Gen 0 | Allocated |
|----------------------- |------------:|-------------:|----------:|------------:|------------:|-----:|----------:|----------:|
|             StringSpan |    641.5 μs |    200.18 μs |  10.97 μs |    629.0 μs |    649.6 μs |    1 |   81.0547 |      1 MB |
|           ArrayReverse |    983.5 μs |     52.19 μs |   2.86 μs |    980.4 μs |    986.1 μs |    2 |  162.1094 |      3 MB |
|             ReverseXor |  1,406.5 μs |    592.11 μs |  32.46 μs |  1,369.1 μs |  1,426.8 μs |    3 |  162.1094 |      3 MB |
|           StackReverse |  7,251.2 μs |  1,279.93 μs |  70.16 μs |  7,190.6 μs |  7,328.0 μs |    4 |  476.5625 |      9 MB |
| StringExtensionReverse |  9,119.4 μs |    117.42 μs |   6.44 μs |  9,112.0 μs |  9,123.3 μs |    5 |  359.3750 |      7 MB |
|      EnumerableReverse | 13,698.2 μs |    183.25 μs |  10.04 μs | 13,691.8 μs | 13,709.8 μs |    6 |  312.5000 |      6 MB |
|       RecursiveReverse | 35,231.1 μs | 10,946.71 μs | 600.03 μs | 34,748.9 μs | 35,903.1 μs |    7 | 3866.6667 |     69 MB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method |        Mean |     Error |  StdDev |         Min |         Max | Allocated |
|------------------------ |------------:|----------:|--------:|------------:|------------:|----------:|
|      CidrBlockNewString | 17,193.3 ns | 179.45 ns | 9.84 ns | 17,185.7 ns | 17,204.4 ns |         - |
|       CidrBlockNewBytes |    275.6 ns |   0.49 ns | 0.03 ns |    275.6 ns |    275.7 ns |         - |
| CidrBlockTryParseString | 19,121.5 ns |  15.11 ns | 0.83 ns | 19,120.5 ns | 19,122.1 ns |         - |
|  CidrBlockTryParseBytes |  1,439.2 ns |   2.98 ns | 0.16 ns |  1,439.1 ns |  1,439.4 ns |         - |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                      Method |      Mean |     Error |    StdDev |       Min |       Max |  Gen 0 | Allocated |
|---------------------------- |----------:|----------:|----------:|----------:|----------:|-------:|----------:|
|    SubnetMaskFromCidrNotion |  3.080 μs | 0.7491 μs | 0.0411 μs |  3.049 μs |  3.126 μs | 0.2975 |      5 KB |
|   SubnetMaskFromCidrAddress | 25.104 μs | 2.0938 μs | 0.1148 μs | 25.031 μs | 25.236 μs | 0.5798 |     11 KB |
|  SubnetMaskFromCidrAddress2 | 23.820 μs | 0.7314 μs | 0.0401 μs | 23.787 μs | 23.865 μs | 0.5798 |     11 KB |
|     SubnetMaskFromIPAddress | 18.689 μs | 0.8449 μs | 0.0463 μs | 18.636 μs | 18.719 μs | 0.2747 |      5 KB |
| SubnetMaskGetNetworkAddress |  8.829 μs | 0.5055 μs | 0.0277 μs |  8.801 μs |  8.856 μs | 0.2899 |      5 KB |
|   SubnetMaskGetAddressRange | 25.886 μs | 1.3537 μs | 0.0742 μs | 25.824 μs | 25.968 μs | 0.8850 |     16 KB |
``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
Intel Xeon Platinum 8272CL CPU 2.60GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=7.0.400
  [Host]   : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT
  ShortRun : .NET 6.0.21 (6.0.2123.36311), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method |    Mean |    Error |   StdDev |     Min |     Max | Allocated |
|--------------- |--------:|---------:|---------:|--------:|--------:|----------:|
|      TaskDelay | 1.199 s | 0.0422 s | 0.0023 s | 1.198 s | 1.202 s |     22 KB |
| ValueTaskDelay | 1.017 s | 0.0129 s | 0.0007 s | 1.016 s | 1.018 s |      1 KB |
