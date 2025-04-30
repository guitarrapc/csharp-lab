```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,368.1 ns** |     **53.46 ns** |     **2.93 ns** |     **1,365.2 ns** |     **1,371.1 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,565.5 ns |    121.46 ns |     6.66 ns |     1,558.7 ns |     1,572.0 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,826.9 ns |     28.19 ns |     1.55 ns |     1,825.8 ns |     1,828.6 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,761.3 ns |    403.19 ns |    22.10 ns |     2,743.0 ns |     2,785.8 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       211.0 ns |     54.53 ns |     2.99 ns |       208.6 ns |       214.4 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       293.7 ns |     65.62 ns |     3.60 ns |       290.3 ns |       297.5 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       577.6 ns |    171.62 ns |     9.41 ns |       571.2 ns |       588.4 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,362.6 ns |     47.77 ns |     2.62 ns |     1,360.5 ns |     1,365.5 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,543.9 ns |    129.84 ns |     7.12 ns |     1,537.3 ns |     1,551.4 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,799.3 ns |    164.85 ns |     9.04 ns |     1,790.0 ns |     1,808.0 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     3,061.8 ns |     42.43 ns |     2.33 ns |     3,060.2 ns |     3,064.5 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       192.5 ns |     79.19 ns |     4.34 ns |       187.5 ns |       195.7 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       281.6 ns |     38.66 ns |     2.12 ns |       279.2 ns |       283.4 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       502.7 ns |     39.21 ns |     2.15 ns |       500.2 ns |       503.9 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,507.5 ns** |  **7,902.21 ns** |   **433.15 ns** | **1,554,030.6 ns** | **1,554,876.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,608.4 ns |  1,565.17 ns |    85.79 ns |   617,516.9 ns |   617,687.0 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,625.4 ns | 12,618.15 ns |   691.64 ns |   658,899.3 ns |   660,276.4 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,385,332.5 ns | 51,082.93 ns | 2,800.03 ns | 1,382,179.2 ns | 1,387,528.0 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,687.6 ns |  8,824.80 ns |   483.72 ns |   163,134.5 ns |   164,032.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,147.3 ns |  4,007.41 ns |   219.66 ns |    91,925.0 ns |    92,364.3 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,444.6 ns |  5,408.38 ns |   296.45 ns |    66,202.8 ns |    66,775.4 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,554,320.8 ns |    758.30 ns |    41.57 ns | 1,554,275.8 ns | 1,554,357.7 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   618,130.6 ns | 12,172.95 ns |   667.24 ns |   617,630.0 ns |   618,888.1 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,658.5 ns | 22,275.35 ns | 1,220.99 ns |   658,844.6 ns |   661,062.4 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,381,728.5 ns | 24,783.82 ns | 1,358.48 ns | 1,380,797.8 ns | 1,383,287.4 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,735.1 ns |  8,324.92 ns |   456.32 ns |   163,301.5 ns |   164,211.2 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,997.3 ns |    291.09 ns |    15.96 ns |    92,981.4 ns |    93,013.3 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,100.4 ns |  1,483.21 ns |    81.30 ns |    34,034.0 ns |    34,191.0 ns |      - |      40 B |
