```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,329.2 ns** |     **107.32 ns** |     **5.88 ns** |     **1,325.7 ns** |     **1,336.0 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,550.1 ns |     128.15 ns |     7.02 ns |     1,545.7 ns |     1,558.2 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,784.2 ns |     231.76 ns |    12.70 ns |     1,772.8 ns |     1,797.9 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,760.1 ns |      92.92 ns |     5.09 ns |     2,754.2 ns |     2,763.5 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       205.3 ns |      30.66 ns |     1.68 ns |       203.4 ns |       206.4 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       272.3 ns |      43.64 ns |     2.39 ns |       269.9 ns |       274.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       473.9 ns |      76.28 ns |     4.18 ns |       469.6 ns |       477.9 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,336.3 ns |      21.01 ns |     1.15 ns |     1,335.0 ns |     1,337.1 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,524.3 ns |      76.21 ns |     4.18 ns |     1,519.8 ns |     1,528.1 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,741.4 ns |     126.65 ns |     6.94 ns |     1,733.5 ns |     1,746.5 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,744.2 ns |     142.15 ns |     7.79 ns |     2,735.8 ns |     2,751.1 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       186.0 ns |      34.17 ns |     1.87 ns |       184.2 ns |       188.0 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       262.5 ns |      16.79 ns |     0.92 ns |       261.6 ns |       263.5 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       486.6 ns |     112.61 ns |     6.17 ns |       481.4 ns |       493.4 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,319.8 ns** |   **8,130.50 ns** |   **445.66 ns** | **1,553,902.9 ns** | **1,554,789.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   618,026.3 ns |  10,036.83 ns |   550.15 ns |   617,617.5 ns |   618,651.8 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   658,927.9 ns |   5,399.36 ns |   295.96 ns |   658,711.6 ns |   659,265.2 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,392,185.9 ns |  49,614.18 ns | 2,719.52 ns | 1,389,625.1 ns | 1,395,040.3 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   165,008.2 ns |  60,395.74 ns | 3,310.49 ns |   163,081.2 ns |   168,830.8 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,178.6 ns |   5,046.61 ns |   276.62 ns |    91,862.2 ns |    92,374.6 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,850.2 ns |   8,721.78 ns |   478.07 ns |    65,529.3 ns |    66,399.7 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,589.4 ns |  10,085.91 ns |   552.84 ns | 1,553,194.2 ns | 1,554,221.2 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,737.8 ns |   3,696.53 ns |   202.62 ns |   617,602.4 ns |   617,970.8 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,397.4 ns |  15,853.36 ns |   868.98 ns |   658,415.1 ns |   660,065.9 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,386,601.6 ns | 102,320.07 ns | 5,608.51 ns | 1,380,184.6 ns | 1,390,566.2 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,399.2 ns |   5,135.27 ns |   281.48 ns |   163,190.1 ns |   163,719.2 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,094.6 ns |   6,007.47 ns |   329.29 ns |    91,884.0 ns |    92,474.1 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,983.3 ns |   7,177.74 ns |   393.44 ns |    33,714.6 ns |    34,434.9 ns |      - |      40 B |
