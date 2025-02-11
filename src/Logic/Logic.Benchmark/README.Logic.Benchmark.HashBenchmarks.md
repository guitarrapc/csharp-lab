```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,249.8 ns** |     **146.22 ns** |      **8.01 ns** |     **1,243.0 ns** |     **1,258.7 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,425.0 ns |      81.88 ns |      4.49 ns |     1,420.4 ns |     1,429.4 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,730.9 ns |     974.13 ns |     53.40 ns |     1,697.4 ns |     1,792.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,665.7 ns |     146.15 ns |      8.01 ns |     2,658.9 ns |     2,674.6 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       210.6 ns |     114.68 ns |      6.29 ns |       206.4 ns |       217.9 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       276.7 ns |     145.33 ns |      7.97 ns |       268.6 ns |       284.5 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       513.9 ns |     446.60 ns |     24.48 ns |       499.3 ns |       542.2 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,262.4 ns |      71.33 ns |      3.91 ns |     1,258.0 ns |     1,265.2 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,455.2 ns |     154.34 ns |      8.46 ns |     1,447.5 ns |     1,464.3 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,637.5 ns |     258.15 ns |     14.15 ns |     1,621.1 ns |     1,646.3 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,701.6 ns |     283.18 ns |     15.52 ns |     2,692.1 ns |     2,719.5 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       188.0 ns |      36.63 ns |      2.01 ns |       186.8 ns |       190.3 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       260.7 ns |     184.20 ns |     10.10 ns |       251.8 ns |       271.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       492.1 ns |      68.87 ns |      3.77 ns |       489.6 ns |       496.4 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,021.1 ns** |   **3,065.28 ns** |    **168.02 ns** | **1,553,873.0 ns** | **1,554,203.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,557.1 ns |   1,316.59 ns |     72.17 ns |   617,475.7 ns |   617,613.2 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,610.9 ns |  20,526.75 ns |  1,125.14 ns |   658,432.6 ns |   660,674.1 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,415,415.6 ns | 927,754.44 ns | 50,853.35 ns | 1,380,541.8 ns | 1,473,766.2 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,881.2 ns |  13,994.85 ns |    767.11 ns |   163,077.1 ns |   164,605.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    91,954.6 ns |   2,963.22 ns |    162.42 ns |    91,849.2 ns |    92,141.6 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,517.9 ns |   2,314.84 ns |    126.88 ns |    65,391.9 ns |    65,645.7 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,586.0 ns |   9,896.13 ns |    542.44 ns | 1,553,132.0 ns | 1,554,186.7 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,667.8 ns |   4,470.30 ns |    245.03 ns |   617,436.1 ns |   617,924.3 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   658,531.7 ns |   1,809.65 ns |     99.19 ns |   658,440.9 ns |   658,637.5 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,382,491.3 ns |  42,867.35 ns |  2,349.70 ns | 1,379,957.4 ns | 1,384,598.3 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,341.3 ns |   3,201.13 ns |    175.46 ns |   163,140.0 ns |   163,461.7 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,859.5 ns |   1,143.65 ns |     62.69 ns |    91,808.8 ns |    91,929.6 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,048.9 ns |   5,909.30 ns |    323.91 ns |    32,832.3 ns |    33,421.2 ns |      - |      40 B |
