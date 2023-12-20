# Logic.Benchmark.BinaryArrayConverterBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                       Method | Number |         Mean |        Error |    StdDev |          Min |          Max |  Gen 0 | Allocated |
|----------------------------- |------- |-------------:|-------------:|----------:|-------------:|-------------:|-------:|----------:|
|             **ToBinaryArrayInt** |      **1** |     **18.30 ns** |     **7.867 ns** |  **0.431 ns** |     **17.92 ns** |     **18.77 ns** | **0.0004** |      **32 B** |
| ToBinaryArrayConvertToString |      1 |     67.03 ns |     2.796 ns |  0.153 ns |     66.87 ns |     67.17 ns | 0.0011 |      96 B |
|          ToBinaryArrayIntMod |      1 |     21.02 ns |     6.553 ns |  0.359 ns |     20.61 ns |     21.31 ns | 0.0004 |      32 B |
|    ToBinaryArrayIntModNumber |      1 |     11.53 ns |     0.792 ns |  0.043 ns |     11.49 ns |     11.58 ns | 0.0004 |      32 B |
|             **ToBinaryArrayInt** |     **10** |    **178.64 ns** |    **17.759 ns** |  **0.973 ns** |    **177.89 ns** |    **179.74 ns** | **0.0038** |     **320 B** |
| ToBinaryArrayConvertToString |     10 |    696.57 ns |    29.184 ns |  1.600 ns |    695.43 ns |    698.40 ns | 0.0114 |   1,024 B |
|          ToBinaryArrayIntMod |     10 |    209.48 ns |    24.138 ns |  1.323 ns |    208.71 ns |    211.00 ns | 0.0038 |     320 B |
|    ToBinaryArrayIntModNumber |     10 |    154.56 ns |    10.819 ns |  0.593 ns |    153.95 ns |    155.14 ns | 0.0038 |     320 B |
|             **ToBinaryArrayInt** |    **100** |  **1,799.39 ns** | **1,152.417 ns** | **63.168 ns** |  **1,726.48 ns** |  **1,837.69 ns** | **0.0381** |   **3,200 B** |
| ToBinaryArrayConvertToString |    100 |  7,121.68 ns |   207.768 ns | 11.388 ns |  7,110.76 ns |  7,133.48 ns | 0.1297 |  10,928 B |
|          ToBinaryArrayIntMod |    100 |  2,001.65 ns |   661.736 ns | 36.272 ns |  1,972.16 ns |  2,042.15 ns | 0.0381 |   3,200 B |
|    ToBinaryArrayIntModNumber |    100 |  1,821.33 ns |   284.680 ns | 15.604 ns |  1,803.42 ns |  1,832.00 ns | 0.0381 |   3,200 B |
|             **ToBinaryArrayInt** |    **255** |  **4,395.88 ns** |   **369.856 ns** | **20.273 ns** |  **4,378.32 ns** |  **4,418.07 ns** | **0.0916** |   **8,160 B** |
| ToBinaryArrayConvertToString |    255 | 16,608.14 ns | 1,156.332 ns | 63.382 ns | 16,538.58 ns | 16,662.63 ns | 0.2747 |  23,208 B |
|          ToBinaryArrayIntMod |    255 |  4,982.07 ns | 1,195.586 ns | 65.534 ns |  4,916.26 ns |  5,047.33 ns | 0.0916 |   8,160 B |
|    ToBinaryArrayIntModNumber |    255 |  5,108.32 ns |   260.129 ns | 14.259 ns |  5,100.01 ns |  5,124.78 ns | 0.0916 |   8,160 B |
# Logic.Benchmark.StringSplitBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |           Mean |        Error |      StdDev |            Min |            Max |   Gen 0 |   Allocated |
|------------------- |------- |---------------:|-------------:|------------:|---------------:|---------------:|--------:|------------:|
| **StringSplitNoAlloc** |      **1** |       **802.1 ns** |     **43.11 ns** |     **2.36 ns** |       **800.4 ns** |       **804.8 ns** |       **-** |           **-** |
|        StringSplit |      1 |     1,584.4 ns |    663.69 ns |    36.38 ns |     1,554.1 ns |     1,624.7 ns |  0.0381 |     3,208 B |
| **StringSplitNoAlloc** |     **10** |     **8,020.8 ns** |     **93.00 ns** |     **5.10 ns** |     **8,015.1 ns** |     **8,025.0 ns** |       **-** |           **-** |
|        StringSplit |     10 |    15,076.9 ns |  1,150.09 ns |    63.04 ns |    15,017.1 ns |    15,142.8 ns |  0.3815 |    32,080 B |
| **StringSplitNoAlloc** |    **100** |    **83,311.4 ns** |  **3,446.92 ns** |   **188.94 ns** |    **83,096.8 ns** |    **83,452.7 ns** |       **-** |           **-** |
|        StringSplit |    100 |   149,701.6 ns |  8,477.20 ns |   464.66 ns |   149,346.1 ns |   150,227.4 ns |  3.6621 |   320,800 B |
| **StringSplitNoAlloc** |   **1000** |   **804,643.8 ns** | **17,295.92 ns** |   **948.05 ns** |   **804,075.6 ns** |   **805,738.2 ns** |       **-** |           **-** |
|        StringSplit |   1000 | 1,474,470.8 ns | 59,298.96 ns | 3,250.38 ns | 1,471,161.6 ns | 1,477,658.9 ns | 37.1094 | 3,208,001 B |
# Logic.Benchmark.StringReverseBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                 Method | Number |             Mean |            Error |         StdDev |              Min |              Max |    Gen 0 |    Allocated |
|----------------------- |------- |-----------------:|-----------------:|---------------:|-----------------:|-----------------:|---------:|-------------:|
|           **ArrayReverse** |      **1** |         **54.02 ns** |        **13.621 ns** |       **0.747 ns** |         **53.51 ns** |         **54.88 ns** |   **0.0036** |        **304 B** |
|      EnumerableReverse |      1 |        424.99 ns |         6.975 ns |       0.382 ns |        424.75 ns |        425.43 ns |   0.0072 |        600 B |
|       RecursiveReverse |      1 |      1,524.29 ns |       117.993 ns |       6.468 ns |      1,518.09 ns |      1,531.00 ns |   0.0858 |      7,272 B |
|             ReverseXor |      1 |        124.84 ns |         2.776 ns |       0.152 ns |        124.73 ns |        125.01 ns |   0.0036 |        304 B |
|           StackReverse |      1 |        412.79 ns |        11.219 ns |       0.615 ns |        412.11 ns |        413.30 ns |   0.0105 |        896 B |
|             StringSpan |      1 |         32.85 ns |         2.111 ns |       0.116 ns |         32.72 ns |         32.95 ns |   0.0018 |        152 B |
| StringExtensionReverse |      1 |        394.92 ns |        24.535 ns |       1.345 ns |        393.38 ns |        395.83 ns |   0.0081 |        696 B |
|           **ArrayReverse** |     **10** |        **457.74 ns** |       **166.959 ns** |       **9.152 ns** |        **447.32 ns** |        **464.46 ns** |   **0.0362** |      **3,040 B** |
|      EnumerableReverse |     10 |      4,035.81 ns |       163.396 ns |       8.956 ns |      4,029.35 ns |      4,046.04 ns |   0.0687 |      6,000 B |
|       RecursiveReverse |     10 |     15,508.65 ns |     3,223.774 ns |     176.706 ns |     15,354.32 ns |     15,701.41 ns |   0.8545 |     72,720 B |
|             ReverseXor |     10 |      1,155.59 ns |        52.842 ns |       2.896 ns |      1,152.25 ns |      1,157.36 ns |   0.0362 |      3,040 B |
|           StackReverse |     10 |      4,021.04 ns |       399.458 ns |      21.896 ns |      4,001.19 ns |      4,044.52 ns |   0.1068 |      8,960 B |
|             StringSpan |     10 |        259.33 ns |        42.147 ns |       2.310 ns |        257.32 ns |        261.85 ns |   0.0181 |      1,520 B |
| StringExtensionReverse |     10 |      3,938.15 ns |        83.501 ns |       4.577 ns |      3,933.13 ns |      3,942.10 ns |   0.0763 |      6,960 B |
|           **ArrayReverse** |    **100** |      **4,433.96 ns** |       **591.552 ns** |      **32.425 ns** |      **4,398.25 ns** |      **4,461.55 ns** |   **0.3586** |     **30,400 B** |
|      EnumerableReverse |    100 |     40,501.13 ns |       996.781 ns |      54.637 ns |     40,460.86 ns |     40,563.32 ns |   0.6714 |     60,000 B |
|       RecursiveReverse |    100 |    151,542.26 ns |    16,818.462 ns |     921.877 ns |    150,854.74 ns |    152,589.82 ns |   8.5449 |    727,200 B |
|             ReverseXor |    100 |     11,296.70 ns |       966.599 ns |      52.983 ns |     11,261.96 ns |     11,357.68 ns |   0.3510 |     30,400 B |
|           StackReverse |    100 |     40,010.60 ns |     1,815.867 ns |      99.534 ns |     39,911.13 ns |     40,110.20 ns |   1.0376 |     89,600 B |
|             StringSpan |    100 |      2,514.58 ns |       595.745 ns |      32.655 ns |      2,485.44 ns |      2,549.87 ns |   0.1793 |     15,200 B |
| StringExtensionReverse |    100 |     39,490.14 ns |     7,548.767 ns |     413.773 ns |     39,197.35 ns |     39,963.51 ns |   0.7935 |     69,600 B |
|           **ArrayReverse** |   **1000** |     **43,818.31 ns** |     **7,911.396 ns** |     **433.650 ns** |     **43,499.33 ns** |     **44,312.08 ns** |   **3.6011** |    **304,000 B** |
|      EnumerableReverse |   1000 |    405,546.84 ns |    31,245.016 ns |   1,712.645 ns |    403,967.75 ns |    407,367.40 ns |   6.8359 |    600,000 B |
|       RecursiveReverse |   1000 |  1,512,749.60 ns |   224,451.537 ns |  12,302.946 ns |  1,503,238.44 ns |  1,526,643.88 ns |  85.9375 |  7,272,001 B |
|             ReverseXor |   1000 |    113,786.09 ns |     2,928.504 ns |     160.521 ns |    113,676.09 ns |    113,970.29 ns |   3.5400 |    304,000 B |
|           StackReverse |   1000 |    397,216.34 ns |     7,689.545 ns |     421.490 ns |    396,730.56 ns |    397,485.16 ns |  10.2539 |    896,000 B |
|             StringSpan |   1000 |     25,310.08 ns |     4,842.841 ns |     265.452 ns |     25,006.38 ns |     25,497.84 ns |   1.8005 |    152,000 B |
| StringExtensionReverse |   1000 |    385,180.93 ns |     7,772.725 ns |     426.049 ns |    384,799.99 ns |    385,640.99 ns |   8.3008 |    696,000 B |
|           **ArrayReverse** |  **10000** |    **429,739.51 ns** |    **53,354.445 ns** |   **2,924.537 ns** |    **426,467.70 ns** |    **432,099.54 ns** |  **36.1328** |  **3,040,000 B** |
|      EnumerableReverse |  10000 |  4,045,666.82 ns |    48,048.715 ns |   2,633.712 ns |  4,042,783.91 ns |  4,047,946.76 ns |  70.3125 |  6,000,005 B |
|       RecursiveReverse |  10000 | 15,261,741.44 ns | 3,037,438.835 ns | 166,492.272 ns | 15,087,541.17 ns | 15,419,271.52 ns | 859.3750 | 72,720,010 B |
|             ReverseXor |  10000 |  1,143,182.24 ns |    78,868.275 ns |   4,323.036 ns |  1,139,825.15 ns |  1,148,060.18 ns |  35.1563 |  3,040,001 B |
|           StackReverse |  10000 |  4,016,052.93 ns |   533,373.197 ns |  29,235.985 ns |  3,985,144.04 ns |  4,043,264.21 ns | 101.5625 |  8,960,005 B |
|             StringSpan |  10000 |    252,884.80 ns |    53,830.712 ns |   2,950.643 ns |    250,715.42 ns |    256,244.71 ns |  18.0664 |  1,520,000 B |
| StringExtensionReverse |  10000 |  3,878,343.55 ns |   216,851.745 ns |  11,886.376 ns |  3,869,472.60 ns |  3,891,849.07 ns |  82.0313 |  6,960,003 B |
# Logic.Benchmark.ExponentialBackoffBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|             Method | Number |      Mean |     Error |   StdDev |       Min |       Max | Allocated |
|------------------- |------- |----------:|----------:|---------:|----------:|----------:|----------:|
| **ExponentialBackoff** |      **1** |  **11.98 ms** |  **0.358 ms** | **0.020 ms** |  **11.96 ms** |  **11.99 ms** |     **519 B** |
| **ExponentialBackoff** |     **10** | **753.02 ms** | **18.953 ms** | **1.039 ms** | **751.82 ms** | **753.65 ms** |         **-** |
# Logic.Benchmark.StopwatchBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |        Mean |     Error |   StdDev |         Min |         Max |  Gen 0 | Allocated |
|--------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
|      **Stopwatch** |      **1** |    **61.69 ns** |  **5.264 ns** | **0.289 ns** |    **61.40 ns** |    **61.98 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |      1 |    56.66 ns |  1.875 ns | 0.103 ns |    56.58 ns |    56.77 ns |      - |         - |
|      **Stopwatch** |     **10** |   **318.55 ns** | **15.565 ns** | **0.853 ns** |   **317.98 ns** |   **319.53 ns** | **0.0005** |      **40 B** |
| ValueStopwatch |     10 |   309.94 ns |  2.273 ns | 0.125 ns |   309.86 ns |   310.09 ns |      - |         - |
|      **Stopwatch** |    **100** | **2,886.16 ns** | **83.773 ns** | **4.592 ns** | **2,882.93 ns** | **2,891.41 ns** |      **-** |      **40 B** |
| ValueStopwatch |    100 | 2,842.42 ns | 19.442 ns | 1.066 ns | 2,841.72 ns | 2,843.64 ns |      - |         - |
# Logic.Benchmark.ValueTaskDelayBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|         Method | Number |      Mean |    Error |   StdDev |       Min |       Max | Allocated |
|--------------- |------- |----------:|---------:|---------:|----------:|----------:|----------:|
|      **TaskDelay** |      **1** |  **11.97 ms** | **0.338 ms** | **0.019 ms** |  **11.96 ms** |  **11.99 ms** |     **351 B** |
| ValueTaskDelay |      1 |  10.14 ms | 0.167 ms | 0.009 ms |  10.13 ms |  10.15 ms |     191 B |
|      **TaskDelay** |     **10** | **119.62 ms** | **1.411 ms** | **0.077 ms** | **119.53 ms** | **119.69 ms** |   **2,040 B** |
| ValueTaskDelay |     10 | 101.09 ms | 0.410 ms | 0.022 ms | 101.07 ms | 101.11 ms |         - |
# Logic.Benchmark.Networks.SubnetMaskBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                      Method | Number |         Mean |        Error |     StdDev |          Min |          Max |  Gen 0 | Allocated |
|---------------------------- |------- |-------------:|-------------:|-----------:|-------------:|-------------:|-------:|----------:|
|    **SubnetMaskFromCidrNotion** |      **1** |     **18.00 ns** |     **4.694 ns** |   **0.257 ns** |     **17.74 ns** |     **18.25 ns** | **0.0007** |      **56 B** |
|   SubnetMaskFromCidrAddress |      1 |    124.92 ns |     4.797 ns |   0.263 ns |    124.62 ns |    125.08 ns | 0.0012 |     112 B |
|  SubnetMaskFromCidrAddress2 |      1 |    111.60 ns |     4.633 ns |   0.254 ns |    111.40 ns |    111.88 ns | 0.0013 |     112 B |
|     SubnetMaskFromIPAddress |      1 |     82.55 ns |     2.063 ns |   0.113 ns |     82.42 ns |     82.62 ns | 0.0006 |      56 B |
| SubnetMaskGetNetworkAddress |      1 |     45.12 ns |    16.842 ns |   0.923 ns |     44.21 ns |     46.06 ns | 0.0007 |      56 B |
|   SubnetMaskGetAddressRange |      1 |    121.28 ns |    20.564 ns |   1.127 ns |    120.17 ns |    122.43 ns | 0.0019 |     168 B |
|    **SubnetMaskFromCidrNotion** |     **10** |    **189.72 ns** |    **45.272 ns** |   **2.482 ns** |    **186.87 ns** |    **191.40 ns** | **0.0067** |     **560 B** |
|   SubnetMaskFromCidrAddress |     10 |  1,184.49 ns |   458.002 ns |  25.105 ns |  1,169.08 ns |  1,213.46 ns | 0.0134 |   1,120 B |
|  SubnetMaskFromCidrAddress2 |     10 |  1,090.82 ns |    54.228 ns |   2.972 ns |  1,088.06 ns |  1,093.97 ns | 0.0134 |   1,120 B |
|     SubnetMaskFromIPAddress |     10 |    829.76 ns |    22.510 ns |   1.234 ns |    828.43 ns |    830.86 ns | 0.0067 |     560 B |
| SubnetMaskGetNetworkAddress |     10 |    450.36 ns |    42.281 ns |   2.318 ns |    447.89 ns |    452.49 ns | 0.0067 |     560 B |
|   SubnetMaskGetAddressRange |     10 |  1,215.07 ns |    62.132 ns |   3.406 ns |  1,213.06 ns |  1,219.01 ns | 0.0191 |   1,680 B |
|    **SubnetMaskFromCidrNotion** |    **100** |  **1,793.36 ns** |    **38.994 ns** |   **2.137 ns** |  **1,790.90 ns** |  **1,794.76 ns** | **0.0668** |   **5,600 B** |
|   SubnetMaskFromCidrAddress |    100 | 11,673.26 ns |   123.427 ns |   6.765 ns | 11,666.85 ns | 11,680.33 ns | 0.1221 |  11,200 B |
|  SubnetMaskFromCidrAddress2 |    100 | 10,744.23 ns |   356.582 ns |  19.545 ns | 10,728.83 ns | 10,766.22 ns | 0.1221 |  11,200 B |
|     SubnetMaskFromIPAddress |    100 |  8,552.76 ns |   292.930 ns |  16.056 ns |  8,535.77 ns |  8,567.68 ns | 0.0610 |   5,600 B |
| SubnetMaskGetNetworkAddress |    100 |  4,327.77 ns |   113.159 ns |   6.203 ns |  4,321.81 ns |  4,334.19 ns | 0.0610 |   5,600 B |
|   SubnetMaskGetAddressRange |    100 | 11,979.76 ns | 7,943.804 ns | 435.427 ns | 11,611.25 ns | 12,460.24 ns | 0.1984 |  16,800 B |
# Logic.Benchmark.Networks.CidrBlockBenchmarks-report-github.md

``` ini

BenchmarkDotNet=v0.13.1, OS=ubuntu 22.04
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK=8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
|                  Method | Number |          Mean |       Error |    StdDev |           Min |           Max | Allocated |
|------------------------ |------- |--------------:|------------:|----------:|--------------:|--------------:|----------:|
|      **CidrBlockNewString** |      **1** |    **62.6788 ns** |   **9.5966 ns** | **0.5260 ns** |    **62.3616 ns** |    **63.2860 ns** |         **-** |
|       CidrBlockNewBytes |      1 |     0.3099 ns |   0.0214 ns | 0.0012 ns |     0.3085 ns |     0.3106 ns |         - |
| CidrBlockTryParseString |      1 |    63.0474 ns |   1.1675 ns | 0.0640 ns |    62.9829 ns |    63.1109 ns |         - |
|  CidrBlockTryParseBytes |      1 |     3.1741 ns |   0.1114 ns | 0.0061 ns |     3.1674 ns |     3.1793 ns |         - |
|      **CidrBlockNewString** |     **10** |   **625.9312 ns** |   **3.4006 ns** | **0.1864 ns** |   **625.7466 ns** |   **626.1194 ns** |         **-** |
|       CidrBlockNewBytes |     10 |     2.9347 ns |   1.2401 ns | 0.0680 ns |     2.8889 ns |     3.0128 ns |         - |
| CidrBlockTryParseString |     10 |   651.7850 ns |  35.7097 ns | 1.9574 ns |   649.7980 ns |   653.7113 ns |         - |
|  CidrBlockTryParseBytes |     10 |    28.5196 ns |   0.0689 ns | 0.0038 ns |    28.5162 ns |    28.5236 ns |         - |
|      **CidrBlockNewString** |    **100** | **5,966.8267 ns** | **107.5387 ns** | **5.8946 ns** | **5,960.0692 ns** | **5,970.9112 ns** |         **-** |
|       CidrBlockNewBytes |    100 |    69.7362 ns |  25.1614 ns | 1.3792 ns |    68.7627 ns |    71.3144 ns |         - |
| CidrBlockTryParseString |    100 | 6,206.8735 ns |  83.8208 ns | 4.5945 ns | 6,204.1554 ns | 6,212.1782 ns |         - |
|  CidrBlockTryParseBytes |    100 |   290.6521 ns |   0.6668 ns | 0.0365 ns |   290.6123 ns |   290.6842 ns |         - |
