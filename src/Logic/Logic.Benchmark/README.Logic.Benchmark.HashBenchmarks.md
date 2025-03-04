```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,265.9 ns** |      **12.53 ns** |     **0.69 ns** |     **1,265.1 ns** |     **1,266.4 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,444.0 ns |      27.37 ns |     1.50 ns |     1,442.6 ns |     1,445.6 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,690.1 ns |     201.13 ns |    11.02 ns |     1,683.6 ns |     1,702.8 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,594.4 ns |     546.85 ns |    29.97 ns |     2,563.1 ns |     2,622.8 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       189.6 ns |       9.30 ns |     0.51 ns |       189.1 ns |       190.1 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       271.6 ns |      58.97 ns |     3.23 ns |       268.3 ns |       274.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       455.3 ns |      85.69 ns |     4.70 ns |       451.6 ns |       460.6 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,262.7 ns |     700.38 ns |    38.39 ns |     1,235.0 ns |     1,306.5 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,432.7 ns |      28.39 ns |     1.56 ns |     1,430.9 ns |     1,433.8 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,707.9 ns |      78.64 ns |     4.31 ns |     1,703.3 ns |     1,711.9 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,652.8 ns |     160.39 ns |     8.79 ns |     2,642.8 ns |     2,658.9 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       180.0 ns |       1.88 ns |     0.10 ns |       179.9 ns |       180.1 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       253.0 ns |      44.04 ns |     2.41 ns |       251.2 ns |       255.8 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       465.2 ns |      17.57 ns |     0.96 ns |       464.1 ns |       466.1 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,129.8 ns** |   **4,479.72 ns** |   **245.55 ns** | **1,552,959.9 ns** | **1,553,411.3 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,144.2 ns |   1,096.15 ns |    60.08 ns |   617,082.9 ns |   617,203.0 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   660,482.0 ns |  10,739.88 ns |   588.69 ns |   659,802.8 ns |   660,845.1 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,384,382.0 ns |  83,054.32 ns | 4,552.49 ns | 1,379,125.4 ns | 1,387,038.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   166,642.1 ns |  90,211.76 ns | 4,944.81 ns |   163,769.0 ns |   172,351.8 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,434.3 ns |   4,676.09 ns |   256.31 ns |    92,138.4 ns |    92,588.2 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,692.0 ns |   5,328.60 ns |   292.08 ns |    65,513.6 ns |    66,029.0 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,561,861.5 ns | 131,247.16 ns | 7,194.10 ns | 1,556,388.4 ns | 1,570,010.0 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   618,278.2 ns |  15,820.11 ns |   867.15 ns |   617,278.8 ns |   618,831.9 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   659,890.4 ns |  25,025.88 ns | 1,371.75 ns |   658,486.0 ns |   661,227.0 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,383,194.0 ns |  55,236.55 ns | 3,027.70 ns | 1,379,714.7 ns | 1,385,229.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,133.4 ns |     471.27 ns |    25.83 ns |   163,112.0 ns |   163,162.1 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,032.5 ns |   5,525.26 ns |   302.86 ns |    91,787.1 ns |    92,371.0 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    32,941.3 ns |   3,852.08 ns |   211.15 ns |    32,807.9 ns |    33,184.8 ns |      - |      40 B |
