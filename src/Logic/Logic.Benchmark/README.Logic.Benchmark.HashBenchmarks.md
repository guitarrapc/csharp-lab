```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,232.6 ns** |    **113.29 ns** |     **6.21 ns** |     **1,227.3 ns** |     **1,239.4 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,419.8 ns |     45.16 ns |     2.48 ns |     1,417.0 ns |     1,421.5 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,643.3 ns |     98.29 ns |     5.39 ns |     1,638.4 ns |     1,649.1 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,614.2 ns |    491.42 ns |    26.94 ns |     2,591.7 ns |     2,644.0 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       187.7 ns |     87.48 ns |     4.80 ns |       182.1 ns |       190.7 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       286.4 ns |    137.92 ns |     7.56 ns |       277.8 ns |       292.0 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       463.6 ns |     71.58 ns |     3.92 ns |       459.1 ns |       466.1 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,232.8 ns |     32.12 ns |     1.76 ns |     1,231.3 ns |     1,234.8 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,413.2 ns |     61.70 ns |     3.38 ns |     1,409.6 ns |     1,416.2 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,661.0 ns |    171.90 ns |     9.42 ns |     1,650.8 ns |     1,669.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,657.3 ns |    343.03 ns |    18.80 ns |     2,639.6 ns |     2,677.0 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       180.9 ns |     47.44 ns |     2.60 ns |       178.8 ns |       183.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       261.3 ns |     23.55 ns |     1.29 ns |       259.9 ns |       262.4 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       468.0 ns |     28.04 ns |     1.54 ns |       466.4 ns |       469.5 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,569.2 ns** |  **9,483.90 ns** |   **519.84 ns** | **1,553,067.4 ns** | **1,554,105.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,437.2 ns |  2,084.35 ns |   114.25 ns |   617,306.3 ns |   617,516.9 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   660,642.4 ns |  8,369.80 ns |   458.78 ns |   660,112.9 ns |   660,919.2 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,391,433.2 ns | 59,689.41 ns | 3,271.78 ns | 1,388,804.2 ns | 1,395,097.3 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,346.5 ns |  8,679.51 ns |   475.75 ns |   163,070.4 ns |   163,895.8 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    93,856.0 ns | 39,708.08 ns | 2,176.53 ns |    91,885.3 ns |    96,192.1 ns |      - |      34 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,618.3 ns |  1,492.20 ns |    81.79 ns |    65,556.9 ns |    65,711.1 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,511.2 ns |  4,158.13 ns |   227.92 ns | 1,553,320.5 ns | 1,553,763.6 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,376.2 ns |  1,405.77 ns |    77.06 ns |   617,311.7 ns |   617,461.5 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   660,143.0 ns | 21,500.52 ns | 1,178.52 ns |   658,784.9 ns |   660,896.3 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,383,839.2 ns | 92,333.32 ns | 5,061.10 ns | 1,379,054.8 ns | 1,389,137.8 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,143.0 ns |    927.27 ns |    50.83 ns |   163,104.0 ns |   163,200.5 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,843.9 ns |    701.01 ns |    38.42 ns |    91,801.8 ns |    91,877.1 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,234.8 ns |  4,290.44 ns |   235.17 ns |    33,976.0 ns |    34,435.5 ns |      - |      40 B |
