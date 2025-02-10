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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,258.7 ns** |     **93.14 ns** |     **5.11 ns** |     **1,255.2 ns** |     **1,264.6 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,458.7 ns |     44.61 ns |     2.45 ns |     1,456.1 ns |     1,460.9 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,933.3 ns |  4,018.66 ns |   220.28 ns |     1,802.5 ns |     2,187.6 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,696.1 ns |    198.94 ns |    10.90 ns |     2,686.4 ns |     2,707.9 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.7 ns |    166.39 ns |     9.12 ns |       192.1 ns |       208.2 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       271.1 ns |     58.88 ns |     3.23 ns |       267.3 ns |       273.0 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       498.1 ns |     48.03 ns |     2.63 ns |       495.1 ns |       499.7 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,555,413.6 ns** | **23,725.00 ns** | **1,300.45 ns** | **1,554,072.8 ns** | **1,556,669.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   618,122.4 ns |  5,459.91 ns |   299.28 ns |   617,830.8 ns |   618,428.8 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,926.7 ns | 15,728.36 ns |   862.12 ns |   659,078.8 ns |   660,802.4 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,380,130.7 ns | 63,265.12 ns | 3,467.77 ns | 1,376,212.4 ns | 1,382,804.7 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,520.6 ns |  4,761.73 ns |   261.01 ns |   163,367.7 ns |   163,822.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,937.9 ns |    422.90 ns |    23.18 ns |    91,911.2 ns |    91,952.8 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    32,971.7 ns |  2,410.71 ns |   132.14 ns |    32,876.3 ns |    33,122.6 ns |      - |      40 B |
