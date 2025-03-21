```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,255.7 ns** |      **51.35 ns** |      **2.81 ns** |     **1,253.9 ns** |     **1,259.0 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,445.3 ns |      41.47 ns |      2.27 ns |     1,442.8 ns |     1,447.2 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,694.4 ns |     188.32 ns |     10.32 ns |     1,687.2 ns |     1,706.2 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,626.3 ns |     456.01 ns |     25.00 ns |     2,601.4 ns |     2,651.4 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       202.2 ns |      59.71 ns |      3.27 ns |       200.1 ns |       205.9 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       278.8 ns |      54.09 ns |      2.97 ns |       275.5 ns |       281.0 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       481.8 ns |     140.19 ns |      7.68 ns |       474.5 ns |       489.8 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,349.4 ns |      65.68 ns |      3.60 ns |     1,346.3 ns |     1,353.3 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,451.3 ns |     108.96 ns |      5.97 ns |     1,447.4 ns |     1,458.2 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,657.9 ns |     196.25 ns |     10.76 ns |     1,648.9 ns |     1,669.8 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,632.9 ns |     132.38 ns |      7.26 ns |     2,628.3 ns |     2,641.3 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       185.1 ns |      25.22 ns |      1.38 ns |       183.8 ns |       186.5 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       266.5 ns |      68.36 ns |      3.75 ns |       262.4 ns |       269.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       480.4 ns |     108.33 ns |      5.94 ns |       474.4 ns |       486.2 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,545.8 ns** |  **11,605.97 ns** |    **636.16 ns** | **1,553,996.3 ns** | **1,555,242.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,701.6 ns |   5,573.33 ns |    305.49 ns |   617,366.7 ns |   617,964.9 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,751.2 ns |  21,468.30 ns |  1,176.75 ns |   658,937.4 ns |   661,100.5 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,383,257.2 ns |  84,406.27 ns |  4,626.59 ns | 1,380,542.6 ns | 1,388,599.3 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,452.5 ns |   9,043.05 ns |    495.68 ns |   163,122.7 ns |   164,022.5 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,372.6 ns |  12,284.13 ns |    673.33 ns |    91,974.7 ns |    93,150.1 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,750.2 ns |   4,312.05 ns |    236.36 ns |    65,561.3 ns |    66,015.3 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,682.1 ns |   9,597.22 ns |    526.06 ns | 1,553,094.6 ns | 1,554,109.5 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,485.5 ns |   1,621.74 ns |     88.89 ns |   617,383.7 ns |   617,547.5 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   658,351.7 ns |   2,724.63 ns |    149.35 ns |   658,216.2 ns |   658,511.8 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,391,267.9 ns | 251,375.93 ns | 13,778.76 ns | 1,379,754.6 ns | 1,406,534.4 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,624.6 ns |   6,569.75 ns |    360.11 ns |   163,216.5 ns |   163,897.7 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    93,006.2 ns |  35,723.29 ns |  1,958.11 ns |    91,862.2 ns |    95,267.2 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,052.0 ns |   9,787.51 ns |    536.49 ns |    33,667.7 ns |    34,664.9 ns |      - |      40 B |
