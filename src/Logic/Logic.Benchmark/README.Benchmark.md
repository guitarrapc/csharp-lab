``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT
  ShortRun : .NET 6.0.25 (6.0.2523.51912), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |         Mean |         Error |      StdDev |          Min |          Max | Allocated |
|------------------------ |------- |-------------:|--------------:|------------:|-------------:|-------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **75.022 ns** |     **2.8148 ns** |   **0.1543 ns** |    **74.845 ns** |    **75.120 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     2.155 ns |     0.2073 ns |   0.0114 ns |     2.147 ns |     2.168 ns |         - |
| CidrBlockTryParseString |      1 |    80.227 ns |     6.2718 ns |   0.3438 ns |    79.964 ns |    80.616 ns |         - |
|  CidrBlockTryParseBytes |      1 |    10.463 ns |     0.0268 ns |   0.0015 ns |    10.462 ns |    10.465 ns |         - |
|      **CidrBlockNewString** |     **10** |   **757.804 ns** |    **16.0743 ns** |   **0.8811 ns** |   **756.787 ns** |   **758.341 ns** |         **-** |
|       CidrBlockNewBytes |     10 |    24.869 ns |     0.2215 ns |   0.0121 ns |    24.856 ns |    24.880 ns |         - |
| CidrBlockTryParseString |     10 |   782.052 ns |    20.8459 ns |   1.1426 ns |   780.884 ns |   783.167 ns |         - |
|  CidrBlockTryParseBytes |     10 |   104.023 ns |     0.8152 ns |   0.0447 ns |   103.985 ns |   104.072 ns |         - |
|      **CidrBlockNewString** |    **100** | **7,494.306 ns** |   **225.7585 ns** |  **12.3746 ns** | **7,484.093 ns** | **7,508.067 ns** |         **-** |
|       CidrBlockNewBytes |    100 |   253.536 ns |     0.7404 ns |   0.0406 ns |   253.493 ns |   253.574 ns |         - |
| CidrBlockTryParseString |    100 | 8,085.414 ns | 2,983.4351 ns | 163.5321 ns | 7,980.124 ns | 8,273.809 ns |         - |
|  CidrBlockTryParseBytes |    100 | 1,051.904 ns |     8.4252 ns |   0.4618 ns | 1,051.437 ns | 1,052.361 ns |         - |
