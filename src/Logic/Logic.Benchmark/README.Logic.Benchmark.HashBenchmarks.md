```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,245.5 ns** |     **50.94 ns** |     **2.79 ns** |     **1,242.9 ns** |     **1,248.4 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,456.6 ns |     44.24 ns |     2.42 ns |     1,453.9 ns |     1,458.6 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,696.5 ns |     17.02 ns |     0.93 ns |     1,695.5 ns |     1,697.4 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,700.5 ns |    626.82 ns |    34.36 ns |     2,673.3 ns |     2,739.1 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       183.2 ns |     42.91 ns |     2.35 ns |       181.1 ns |       185.8 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       266.5 ns |     31.98 ns |     1.75 ns |       264.7 ns |       268.2 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       512.4 ns |    137.92 ns |     7.56 ns |       505.5 ns |       520.5 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,053.6 ns** | **12,485.06 ns** |   **684.35 ns** | **1,553,643.2 ns** | **1,554,843.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,530.9 ns |  1,113.21 ns |    61.02 ns |   617,489.3 ns |   617,600.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,048.3 ns | 18,841.20 ns | 1,032.75 ns |   658,239.2 ns |   660,211.6 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,377,568.6 ns | 62,717.43 ns | 3,437.75 ns | 1,373,601.5 ns | 1,379,675.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,169.3 ns |  2,039.47 ns |   111.79 ns |   163,040.4 ns |   163,239.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,901.3 ns |    586.79 ns |    32.16 ns |    91,864.8 ns |    91,925.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,183.2 ns |  6,867.95 ns |   376.46 ns |    32,829.3 ns |    33,578.8 ns |      - |      40 B |
