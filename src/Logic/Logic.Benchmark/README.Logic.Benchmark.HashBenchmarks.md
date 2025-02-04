```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,251.5 ns** |      **79.97 ns** |      **4.38 ns** |     **1,246.5 ns** |     **1,254.8 ns** | **0.0668** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,449.9 ns |     153.11 ns |      8.39 ns |     1,443.5 ns |     1,459.4 ns | 0.0839 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,701.8 ns |      96.97 ns |      5.32 ns |     1,695.7 ns |     1,705.5 ns | 0.1106 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,663.9 ns |     367.51 ns |     20.14 ns |     2,643.7 ns |     2,684.0 ns | 0.1907 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       194.6 ns |      51.49 ns |      2.82 ns |       191.8 ns |       197.5 ns | 0.0348 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       270.5 ns |      74.12 ns |      4.06 ns |       267.9 ns |       275.1 ns | 0.0434 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       493.8 ns |     113.31 ns |      6.21 ns |       489.4 ns |       500.9 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,553,816.4 ns** |   **8,308.45 ns** |    **455.41 ns** | **1,553,292.0 ns** | **1,554,112.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   617,320.5 ns |   1,613.31 ns |     88.43 ns |   617,218.9 ns |   617,380.4 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   659,746.9 ns |  22,414.83 ns |  1,228.63 ns |   658,542.0 ns |   660,997.9 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,386,953.2 ns | 195,842.10 ns | 10,734.77 ns | 1,380,162.5 ns | 1,399,329.0 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   163,552.9 ns |  14,492.90 ns |    794.40 ns |   162,985.0 ns |   164,460.7 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,018.4 ns |   2,629.46 ns |    144.13 ns |    91,857.0 ns |    92,134.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    33,151.8 ns |   6,036.20 ns |    330.86 ns |    32,916.0 ns |    33,530.0 ns |      - |      40 B |
