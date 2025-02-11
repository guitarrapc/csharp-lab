```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,242.5 ns** |    **127.97 ns** |     **7.01 ns** |     **1,236.2 ns** |     **1,250.0 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,428.8 ns |    101.21 ns |     5.55 ns |     1,422.7 ns |     1,433.5 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,662.5 ns |     29.47 ns |     1.62 ns |     1,661.1 ns |     1,664.3 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,536.8 ns |    220.55 ns |    12.09 ns |     2,524.9 ns |     2,549.0 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       180.6 ns |      3.74 ns |     0.20 ns |       180.5 ns |       180.9 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       281.3 ns |     98.55 ns |     5.40 ns |       275.3 ns |       285.8 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       472.4 ns |     83.32 ns |     4.57 ns |       469.4 ns |       477.7 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,215.6 ns |     24.54 ns |     1.35 ns |     1,214.6 ns |     1,217.2 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,410.5 ns |     21.17 ns |     1.16 ns |     1,409.2 ns |     1,411.4 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,644.2 ns |    166.02 ns |     9.10 ns |     1,638.7 ns |     1,654.7 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,584.0 ns |    137.91 ns |     7.56 ns |     2,577.4 ns |     2,592.2 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       176.0 ns |     59.07 ns |     3.24 ns |       173.1 ns |       179.5 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       256.1 ns |     55.07 ns |     3.02 ns |       253.1 ns |       259.1 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       468.0 ns |     45.43 ns |     2.49 ns |       466.4 ns |       470.9 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,324.6 ns** |  **3,525.58 ns** |   **193.25 ns** | **1,553,103.0 ns** | **1,553,457.8 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,387.3 ns |  3,560.37 ns |   195.16 ns |   617,206.1 ns |   617,593.9 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,307.6 ns | 15,344.44 ns |   841.08 ns |   658,628.1 ns |   660,248.3 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,383,315.5 ns | 68,013.65 ns | 3,728.06 ns | 1,380,510.9 ns | 1,387,546.1 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,131.7 ns |    449.80 ns |    24.65 ns |   163,110.8 ns |   163,158.9 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    91,998.9 ns |  2,631.94 ns |   144.27 ns |    91,848.9 ns |    92,136.7 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,897.8 ns |  4,377.10 ns |   239.92 ns |    65,658.4 ns |    66,138.2 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,556,579.4 ns | 72,002.22 ns | 3,946.68 ns | 1,553,435.9 ns | 1,561,008.6 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,765.9 ns |  7,988.96 ns |   437.90 ns |   617,282.5 ns |   618,136.0 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,748.4 ns | 23,822.77 ns | 1,305.81 ns |   658,284.8 ns |   660,794.2 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,380,863.2 ns | 23,194.98 ns | 1,271.40 ns | 1,379,796.9 ns | 1,382,270.2 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,096.6 ns |  1,144.28 ns |    62.72 ns |   163,035.8 ns |   163,161.1 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,908.0 ns |  1,042.47 ns |    57.14 ns |    91,865.8 ns |    91,973.0 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,695.6 ns |    797.35 ns |    43.71 ns |    33,665.7 ns |    33,745.8 ns |      - |      40 B |
