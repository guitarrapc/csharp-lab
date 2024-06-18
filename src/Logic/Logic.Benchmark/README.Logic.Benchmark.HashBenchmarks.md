```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,312.6 ns** |     **74.12 ns** |     **4.06 ns** |     **1,310.0 ns** |     **1,317.3 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,469.0 ns |    282.76 ns |    15.50 ns |     1,457.4 ns |     1,486.6 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,694.3 ns |     48.40 ns |     2.65 ns |     1,691.6 ns |     1,696.9 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,690.3 ns |    114.91 ns |     6.30 ns |     2,683.1 ns |     2,694.1 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       251.9 ns |    470.53 ns |    25.79 ns |       222.2 ns |       268.6 ns | 0.0067 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       288.6 ns |     41.58 ns |     2.28 ns |       286.4 ns |       290.9 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       494.0 ns |    202.52 ns |    11.10 ns |       487.2 ns |       506.8 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,605.4 ns** | **11,655.36 ns** |   **638.87 ns** | **1,545,188.3 ns** | **1,546,340.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,146.6 ns |  2,126.02 ns |   116.53 ns |   614,020.2 ns |   614,249.7 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   657,015.8 ns | 35,400.22 ns | 1,940.41 ns |   654,876.4 ns |   658,662.2 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,375,611.4 ns | 41,451.99 ns | 2,272.12 ns | 1,373,004.7 ns | 1,377,172.4 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,234.9 ns |  1,582.75 ns |    86.76 ns |   162,171.5 ns |   162,333.8 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,624.5 ns |  6,949.57 ns |   380.93 ns |    91,330.2 ns |    92,054.8 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,129.5 ns |  4,256.44 ns |   233.31 ns |    64,925.8 ns |    65,384.0 ns |      - |      40 B |
