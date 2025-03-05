```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,229.2 ns** |     **84.84 ns** |     **4.65 ns** |     **1,225.3 ns** |     **1,234.4 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,411.2 ns |    295.98 ns |    16.22 ns |     1,399.0 ns |     1,429.6 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,701.5 ns |    346.42 ns |    18.99 ns |     1,683.5 ns |     1,721.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,574.1 ns |    390.81 ns |    21.42 ns |     2,557.2 ns |     2,598.2 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       187.8 ns |     78.00 ns |     4.28 ns |       184.0 ns |       192.4 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       269.7 ns |     20.43 ns |     1.12 ns |       268.5 ns |       270.8 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       469.9 ns |     76.08 ns |     4.17 ns |       465.6 ns |       473.9 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,219.7 ns |     37.97 ns |     2.08 ns |     1,217.3 ns |     1,221.2 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,502.9 ns |    226.35 ns |    12.41 ns |     1,494.6 ns |     1,517.2 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,610.3 ns |     45.97 ns |     2.52 ns |     1,608.3 ns |     1,613.1 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,646.9 ns |    332.28 ns |    18.21 ns |     2,626.0 ns |     2,659.6 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       179.3 ns |     35.85 ns |     1.97 ns |       177.8 ns |       181.5 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       265.9 ns |    203.25 ns |    11.14 ns |       253.4 ns |       274.9 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       469.1 ns |     33.23 ns |     1.82 ns |       467.3 ns |       471.0 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,949.7 ns** | **19,639.55 ns** | **1,076.51 ns** | **1,553,321.1 ns** | **1,555,192.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   618,391.1 ns | 29,156.26 ns | 1,598.15 ns |   617,406.8 ns |   620,235.1 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,287.6 ns | 18,769.58 ns | 1,028.82 ns |   658,301.6 ns |   660,354.5 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,381,194.6 ns | 52,698.41 ns | 2,888.58 ns | 1,379,473.5 ns | 1,384,529.5 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,400.7 ns |  6,812.84 ns |   373.43 ns |   163,112.1 ns |   163,822.5 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    91,884.4 ns |    497.12 ns |    27.25 ns |    91,866.1 ns |    91,915.7 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,360.4 ns |  3,302.37 ns |   181.01 ns |    66,215.8 ns |    66,563.4 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,602.9 ns |  4,323.72 ns |   237.00 ns | 1,553,423.3 ns | 1,553,871.5 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,728.6 ns |  2,095.72 ns |   114.87 ns |   617,643.2 ns |   617,859.2 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   658,828.8 ns |  7,783.38 ns |   426.63 ns |   658,560.8 ns |   659,320.8 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,380,644.3 ns | 46,629.58 ns | 2,555.92 ns | 1,378,828.9 ns | 1,383,567.2 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,106.6 ns |  2,329.00 ns |   127.66 ns |   163,005.0 ns |   163,249.9 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,957.7 ns |  3,223.78 ns |   176.71 ns |    91,823.9 ns |    92,158.0 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,001.6 ns |  6,818.42 ns |   373.74 ns |    33,698.2 ns |    34,419.1 ns |      - |      40 B |
