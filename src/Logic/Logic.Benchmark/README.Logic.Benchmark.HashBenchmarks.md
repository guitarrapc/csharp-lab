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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,238.2 ns** |    **116.45 ns** |     **6.38 ns** |     **1,230.9 ns** |     **1,242.6 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,433.0 ns |     91.22 ns |     5.00 ns |     1,427.6 ns |     1,437.5 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,683.3 ns |    306.26 ns |    16.79 ns |     1,670.6 ns |     1,702.3 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,629.9 ns |    252.99 ns |    13.87 ns |     2,620.5 ns |     2,645.8 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       185.6 ns |     37.87 ns |     2.08 ns |       183.3 ns |       187.4 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       260.9 ns |     69.90 ns |     3.83 ns |       256.7 ns |       264.3 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       488.5 ns |     33.25 ns |     1.82 ns |       486.8 ns |       490.4 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,554,898.9 ns** | **22,149.65 ns** | **1,214.10 ns** | **1,553,650.0 ns** | **1,556,074.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,735.5 ns |  9,700.35 ns |   531.71 ns |   617,307.9 ns |   618,330.9 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   660,633.5 ns | 32,183.72 ns | 1,764.10 ns |   658,635.5 ns |   661,976.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,379,711.3 ns |  3,227.17 ns |   176.89 ns | 1,379,591.3 ns | 1,379,914.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,186.4 ns |  2,627.28 ns |   144.01 ns |   163,070.0 ns |   163,347.5 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,974.0 ns |  2,998.80 ns |   164.37 ns |    91,870.7 ns |    92,163.5 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,552.8 ns |    762.62 ns |    41.80 ns |    33,519.0 ns |    33,599.6 ns |      - |      40 B |
