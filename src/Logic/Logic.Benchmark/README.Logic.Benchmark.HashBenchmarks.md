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
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,247.4 ns** |    **160.45 ns** |     **8.79 ns** |     **1,240.8 ns** |     **1,257.4 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,430.5 ns |     60.71 ns |     3.33 ns |     1,427.1 ns |     1,433.8 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,673.9 ns |    153.65 ns |     8.42 ns |     1,668.3 ns |     1,683.6 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,622.1 ns |    183.79 ns |    10.07 ns |     2,610.9 ns |     2,630.3 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       188.6 ns |      4.13 ns |     0.23 ns |       188.4 ns |       188.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       268.8 ns |     42.35 ns |     2.32 ns |       266.1 ns |       270.3 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       474.0 ns |     43.49 ns |     2.38 ns |       471.4 ns |       476.0 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,230.3 ns |     81.83 ns |     4.49 ns |     1,225.5 ns |     1,234.4 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,406.5 ns |     97.45 ns |     5.34 ns |     1,403.3 ns |     1,412.6 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,658.6 ns |    183.82 ns |    10.08 ns |     1,649.3 ns |     1,669.3 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,575.9 ns |    261.23 ns |    14.32 ns |     2,560.1 ns |     2,588.1 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       178.8 ns |     25.53 ns |     1.40 ns |       177.1 ns |       179.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       263.8 ns |     30.06 ns |     1.65 ns |       262.1 ns |       265.4 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       476.8 ns |     33.85 ns |     1.86 ns |       475.3 ns |       478.8 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,635.5 ns** |  **5,824.80 ns** |   **319.28 ns** | **1,553,362.4 ns** | **1,553,986.5 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,462.7 ns |  4,118.90 ns |   225.77 ns |   617,215.9 ns |   617,658.9 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   658,928.2 ns | 10,384.83 ns |   569.23 ns |   658,526.7 ns |   659,579.6 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,380,558.2 ns | 18,368.63 ns | 1,006.85 ns | 1,379,552.9 ns | 1,381,566.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,784.7 ns | 14,556.04 ns |   797.87 ns |   163,144.1 ns |   164,678.4 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    91,920.6 ns |  1,121.19 ns |    61.46 ns |    91,880.3 ns |    91,991.3 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,544.1 ns |    730.23 ns |    40.03 ns |    65,498.4 ns |    65,573.2 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,706.5 ns |  4,850.26 ns |   265.86 ns | 1,553,406.2 ns | 1,553,912.1 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,305.9 ns |    920.24 ns |    50.44 ns |   617,270.2 ns |   617,363.6 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   660,236.0 ns | 25,653.75 ns | 1,406.17 ns |   658,614.4 ns |   661,117.8 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,380,094.1 ns | 29,629.67 ns | 1,624.10 ns | 1,378,758.3 ns | 1,381,901.9 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,020.0 ns |  1,343.74 ns |    73.65 ns |   162,945.2 ns |   163,092.4 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,938.6 ns |  4,028.67 ns |   220.83 ns |    91,809.9 ns |    92,193.5 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,250.9 ns |  7,912.95 ns |   433.74 ns |    33,750.9 ns |    34,526.4 ns |      - |      40 B |
