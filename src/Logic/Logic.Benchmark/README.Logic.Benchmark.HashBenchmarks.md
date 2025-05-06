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
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,371.4 ns** |     **103.31 ns** |     **5.66 ns** |     **1,367.2 ns** |     **1,377.8 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,577.0 ns |      56.17 ns |     3.08 ns |     1,573.8 ns |     1,579.9 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,806.8 ns |     125.73 ns |     6.89 ns |     1,799.6 ns |     1,813.3 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,787.6 ns |     306.39 ns |    16.79 ns |     2,771.1 ns |     2,804.7 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       203.1 ns |      48.83 ns |     2.68 ns |       200.1 ns |       205.3 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       294.6 ns |      28.83 ns |     1.58 ns |       292.8 ns |       295.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       527.7 ns |      15.46 ns |     0.85 ns |       526.8 ns |       528.5 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,375.6 ns |     107.07 ns |     5.87 ns |     1,369.5 ns |     1,381.2 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,578.0 ns |     152.09 ns |     8.34 ns |     1,568.6 ns |     1,584.4 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,813.6 ns |     244.36 ns |    13.39 ns |     1,804.2 ns |     1,828.9 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,786.7 ns |     120.60 ns |     6.61 ns |     2,782.6 ns |     2,794.3 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       194.6 ns |      15.51 ns |     0.85 ns |       193.7 ns |       195.4 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       297.1 ns |      38.78 ns |     2.13 ns |       295.0 ns |       299.2 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       512.1 ns |     104.54 ns |     5.73 ns |       505.4 ns |       515.6 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,544.0 ns** |   **5,473.74 ns** |   **300.03 ns** | **1,554,214.1 ns** | **1,554,800.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,954.6 ns |   3,637.19 ns |   199.37 ns |   617,774.2 ns |   618,168.6 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   660,002.3 ns |  25,605.47 ns | 1,403.52 ns |   659,087.1 ns |   661,618.2 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,393,778.9 ns | 127,023.94 ns | 6,962.61 ns | 1,386,544.7 ns | 1,400,433.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,861.1 ns |  19,601.92 ns | 1,074.45 ns |   163,202.4 ns |   165,101.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,283.0 ns |   6,311.05 ns |   345.93 ns |    91,979.2 ns |    92,659.5 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,724.6 ns |   3,017.49 ns |   165.40 ns |    65,574.9 ns |    65,902.2 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,557,209.8 ns |  89,768.99 ns | 4,920.54 ns | 1,554,009.0 ns | 1,562,875.6 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   618,001.0 ns |   5,223.58 ns |   286.32 ns |   617,780.2 ns |   618,324.5 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   661,045.3 ns |  61,280.19 ns | 3,358.97 ns |   658,928.5 ns |   664,918.3 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,384,497.4 ns | 114,740.82 ns | 6,289.33 ns | 1,380,812.2 ns | 1,391,759.4 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,686.8 ns |   8,616.76 ns |   472.31 ns |   163,329.4 ns |   164,222.2 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,630.1 ns |  10,474.41 ns |   574.14 ns |    91,969.4 ns |    93,007.1 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,135.2 ns |   6,908.85 ns |   378.70 ns |    33,720.0 ns |    34,461.7 ns |      - |      40 B |
