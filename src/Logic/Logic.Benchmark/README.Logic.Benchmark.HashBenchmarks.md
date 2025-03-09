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
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,231.5 ns** |     **96.51 ns** |     **5.29 ns** |     **1,228.0 ns** |     **1,237.6 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,402.7 ns |    114.46 ns |     6.27 ns |     1,398.9 ns |     1,410.0 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,626.3 ns |    210.61 ns |    11.54 ns |     1,618.6 ns |     1,639.6 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,548.0 ns |    214.04 ns |    11.73 ns |     2,538.6 ns |     2,561.1 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       183.6 ns |     20.64 ns |     1.13 ns |       182.6 ns |       184.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       263.9 ns |      1.96 ns |     0.11 ns |       263.7 ns |       263.9 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       464.1 ns |     34.74 ns |     1.90 ns |       461.9 ns |       465.5 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,221.4 ns |     97.22 ns |     5.33 ns |     1,216.1 ns |     1,226.7 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,376.0 ns |     17.16 ns |     0.94 ns |     1,374.9 ns |     1,376.8 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,608.6 ns |    209.80 ns |    11.50 ns |     1,598.9 ns |     1,621.3 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,536.5 ns |    271.50 ns |    14.88 ns |     2,523.2 ns |     2,552.6 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       176.6 ns |     11.91 ns |     0.65 ns |       175.9 ns |       177.2 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       253.7 ns |     24.91 ns |     1.37 ns |       252.8 ns |       255.2 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       455.0 ns |     35.03 ns |     1.92 ns |       453.0 ns |       456.9 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,181.4 ns** | **15,508.18 ns** |   **850.06 ns** | **1,553,468.3 ns** | **1,555,122.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,755.7 ns |    592.39 ns |    32.47 ns |   617,719.6 ns |   617,782.6 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   661,084.5 ns | 13,888.47 ns |   761.27 ns |   660,242.7 ns |   661,724.5 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,382,202.7 ns | 69,153.62 ns | 3,790.54 ns | 1,379,719.9 ns | 1,386,565.8 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,892.1 ns | 19,734.89 ns | 1,081.74 ns |   163,144.9 ns |   165,132.5 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,218.8 ns |  5,684.21 ns |   311.57 ns |    92,035.2 ns |    92,578.5 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,661.5 ns |  2,695.88 ns |   147.77 ns |    65,536.1 ns |    65,824.4 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,868.1 ns |  8,299.42 ns |   454.92 ns | 1,553,413.0 ns | 1,554,322.9 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,676.5 ns |  1,293.40 ns |    70.90 ns |   617,634.8 ns |   617,758.4 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,291.8 ns | 16,826.93 ns |   922.34 ns |   658,631.6 ns |   660,345.7 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,381,681.7 ns | 54,437.94 ns | 2,983.93 ns | 1,379,479.1 ns | 1,385,077.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,719.9 ns | 13,272.72 ns |   727.52 ns |   163,216.1 ns |   164,554.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,398.8 ns | 16,563.57 ns |   907.91 ns |    91,846.4 ns |    93,446.6 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,375.1 ns |  1,409.86 ns |    77.28 ns |    34,289.5 ns |    34,439.8 ns |      - |      40 B |
