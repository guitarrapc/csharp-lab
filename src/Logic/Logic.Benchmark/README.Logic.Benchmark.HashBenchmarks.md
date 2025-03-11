```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,224.3 ns** |     **184.62 ns** |     **10.12 ns** |     **1,216.1 ns** |     **1,235.6 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,399.7 ns |     142.33 ns |      7.80 ns |     1,391.3 ns |     1,406.7 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,658.2 ns |     616.53 ns |     33.79 ns |     1,637.7 ns |     1,697.2 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,551.1 ns |     280.29 ns |     15.36 ns |     2,533.5 ns |     2,562.1 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       233.8 ns |       3.53 ns |      0.19 ns |       233.6 ns |       234.0 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       263.7 ns |      32.59 ns |      1.79 ns |       262.6 ns |       265.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       460.8 ns |      24.38 ns |      1.34 ns |       459.6 ns |       462.3 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,209.7 ns |      22.73 ns |      1.25 ns |     1,208.3 ns |     1,210.6 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,379.2 ns |      30.16 ns |      1.65 ns |     1,377.6 ns |     1,380.9 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,615.6 ns |      28.66 ns |      1.57 ns |     1,614.6 ns |     1,617.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,521.5 ns |     183.72 ns |     10.07 ns |     2,513.6 ns |     2,532.9 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       174.4 ns |       6.55 ns |      0.36 ns |       174.0 ns |       174.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       251.7 ns |      36.67 ns |      2.01 ns |       249.5 ns |       253.5 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       456.8 ns |       4.93 ns |      0.27 ns |       456.6 ns |       457.1 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,702.4 ns** |   **3,654.36 ns** |    **200.31 ns** | **1,553,494.8 ns** | **1,553,894.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,437.1 ns |     753.96 ns |     41.33 ns |   617,393.0 ns |   617,475.0 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,403.9 ns |  29,053.38 ns |  1,592.51 ns |   658,330.6 ns |   661,233.6 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,386,426.9 ns |  75,297.68 ns |  4,127.32 ns | 1,383,205.5 ns | 1,391,079.2 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,515.2 ns |  10,865.66 ns |    595.58 ns |   163,118.6 ns |   164,200.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    91,892.9 ns |   2,292.74 ns |    125.67 ns |    91,802.1 ns |    92,036.3 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,576.1 ns |   1,050.79 ns |     57.60 ns |    65,512.9 ns |    65,625.8 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,673.6 ns |   6,519.50 ns |    357.36 ns | 1,553,440.2 ns | 1,554,085.0 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,487.0 ns |   1,550.58 ns |     84.99 ns |   617,412.7 ns |   617,579.7 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   658,464.7 ns |   1,092.34 ns |     59.87 ns |   658,397.2 ns |   658,511.6 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,389,188.5 ns | 195,140.54 ns | 10,696.31 ns | 1,381,017.7 ns | 1,401,295.1 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,160.6 ns |   3,701.25 ns |    202.88 ns |   163,000.4 ns |   163,388.8 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,233.7 ns |   5,976.11 ns |    327.57 ns |    91,987.0 ns |    92,605.3 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,461.2 ns |     405.48 ns |     22.23 ns |    34,436.7 ns |    34,480.0 ns |      - |      40 B |
