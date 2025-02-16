```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,255.1 ns** |    **199.82 ns** |    **10.95 ns** |     **1,247.3 ns** |     **1,267.6 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,434.0 ns |    180.36 ns |     9.89 ns |     1,423.6 ns |     1,443.2 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,671.0 ns |    121.66 ns |     6.67 ns |     1,664.5 ns |     1,677.8 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,610.1 ns |    331.46 ns |    18.17 ns |     2,598.9 ns |     2,631.0 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       189.8 ns |     45.26 ns |     2.48 ns |       187.0 ns |       191.7 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       274.7 ns |     21.26 ns |     1.17 ns |       273.5 ns |       275.8 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       490.1 ns |    145.49 ns |     7.97 ns |       482.3 ns |       498.2 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,257.9 ns |    152.42 ns |     8.35 ns |     1,250.3 ns |     1,266.9 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,402.0 ns |     65.00 ns |     3.56 ns |     1,398.1 ns |     1,405.1 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,653.9 ns |    117.19 ns |     6.42 ns |     1,646.5 ns |     1,657.8 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,584.7 ns |     92.80 ns |     5.09 ns |     2,579.9 ns |     2,590.0 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       186.0 ns |     12.53 ns |     0.69 ns |       185.2 ns |       186.4 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       261.2 ns |     37.07 ns |     2.03 ns |       259.5 ns |       263.4 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       477.8 ns |     36.71 ns |     2.01 ns |       476.4 ns |       480.1 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,772.6 ns** |  **9,532.48 ns** |   **522.51 ns** | **1,553,346.1 ns** | **1,554,355.4 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,707.3 ns |  4,564.82 ns |   250.21 ns |   617,524.3 ns |   617,992.4 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   658,581.5 ns |  4,690.35 ns |   257.09 ns |   658,291.0 ns |   658,779.6 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,379,931.4 ns |  2,194.02 ns |   120.26 ns | 1,379,796.3 ns | 1,380,027.0 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,253.3 ns |  7,204.01 ns |   394.88 ns |   162,960.6 ns |   163,702.4 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,101.4 ns |  5,836.85 ns |   319.94 ns |    91,909.9 ns |    92,470.8 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,172.3 ns | 11,232.95 ns |   615.72 ns |    65,495.3 ns |    66,698.7 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,232.8 ns |  2,928.00 ns |   160.49 ns | 1,553,098.8 ns | 1,553,410.7 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,759.7 ns |  2,187.96 ns |   119.93 ns |   617,682.7 ns |   617,897.9 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   658,773.3 ns |  3,385.44 ns |   185.57 ns |   658,608.8 ns |   658,974.5 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,437,483.1 ns | 98,908.49 ns | 5,421.51 ns | 1,431,263.9 ns | 1,441,212.3 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,714.9 ns | 18,646.28 ns | 1,022.07 ns |   163,112.0 ns |   164,895.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    93,071.4 ns | 29,871.77 ns | 1,637.37 ns |    91,954.5 ns |    94,951.0 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,110.3 ns |  6,905.37 ns |   378.51 ns |    33,688.7 ns |    34,421.0 ns |      - |      40 B |
