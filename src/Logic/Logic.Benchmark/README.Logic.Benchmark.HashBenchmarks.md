```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,227.9 ns** |     **100.66 ns** |      **5.52 ns** |     **1,222.4 ns** |     **1,233.4 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,427.7 ns |     395.90 ns |     21.70 ns |     1,402.8 ns |     1,442.8 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,657.7 ns |     429.49 ns |     23.54 ns |     1,641.7 ns |     1,684.7 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,596.6 ns |     121.55 ns |      6.66 ns |     2,589.2 ns |     2,602.0 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       184.0 ns |      20.82 ns |      1.14 ns |       182.7 ns |       184.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       266.2 ns |      60.49 ns |      3.32 ns |       263.1 ns |       269.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       487.1 ns |      10.82 ns |      0.59 ns |       486.6 ns |       487.7 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,210.5 ns |     134.00 ns |      7.35 ns |     1,202.2 ns |     1,216.1 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,388.8 ns |      99.84 ns |      5.47 ns |     1,384.6 ns |     1,395.0 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,628.5 ns |     190.48 ns |     10.44 ns |     1,616.5 ns |     1,635.5 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,520.6 ns |     149.66 ns |      8.20 ns |     2,513.2 ns |     2,529.4 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       172.3 ns |      10.04 ns |      0.55 ns |       171.9 ns |       172.9 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       252.6 ns |       9.72 ns |      0.53 ns |       252.2 ns |       253.2 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       460.0 ns |     168.59 ns |      9.24 ns |       453.7 ns |       470.6 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,552,364.7 ns** |  **41,567.97 ns** |  **2,278.48 ns** | **1,549,739.6 ns** | **1,553,829.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,766.0 ns |   4,995.75 ns |    273.83 ns |   617,552.8 ns |   618,074.9 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,233.8 ns |  13,116.68 ns |    718.97 ns |   658,459.7 ns |   659,880.6 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,381,263.6 ns |  55,414.51 ns |  3,037.46 ns | 1,379,049.4 ns | 1,384,726.4 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,052.4 ns |     710.87 ns |     38.97 ns |   163,008.2 ns |   163,081.9 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    94,314.5 ns |  44,870.86 ns |  2,459.52 ns |    92,770.0 ns |    97,150.7 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,121.1 ns |  10,147.11 ns |    556.20 ns |    65,516.0 ns |    66,610.0 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,382.8 ns |   2,258.02 ns |    123.77 ns | 1,553,276.1 ns | 1,553,518.5 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,382.6 ns |     681.11 ns |     37.33 ns |   617,340.8 ns |   617,412.5 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   660,066.1 ns |  27,750.68 ns |  1,521.11 ns |   658,311.2 ns |   661,007.1 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,412,041.6 ns | 933,274.79 ns | 51,155.94 ns | 1,379,861.3 ns | 1,471,029.9 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,227.8 ns |   4,322.30 ns |    236.92 ns |   163,053.4 ns |   163,497.6 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,937.5 ns |     300.82 ns |     16.49 ns |    91,918.4 ns |    91,947.0 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,891.3 ns |   3,741.68 ns |    205.09 ns |    33,656.7 ns |    34,036.5 ns |      - |      40 B |
