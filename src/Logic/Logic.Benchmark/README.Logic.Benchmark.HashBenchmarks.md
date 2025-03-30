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
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,240.9 ns** |    **226.17 ns** |    **12.40 ns** |     **1,233.6 ns** |     **1,255.2 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,428.9 ns |    194.69 ns |    10.67 ns |     1,416.7 ns |     1,436.1 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,657.6 ns |    143.30 ns |     7.85 ns |     1,652.6 ns |     1,666.7 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,614.1 ns |    220.27 ns |    12.07 ns |     2,605.3 ns |     2,627.9 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       184.8 ns |      1.76 ns |     0.10 ns |       184.7 ns |       184.9 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       273.4 ns |     85.29 ns |     4.68 ns |       268.0 ns |       276.1 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       480.1 ns |     11.31 ns |     0.62 ns |       479.4 ns |       480.6 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,228.7 ns |     79.58 ns |     4.36 ns |     1,224.5 ns |     1,233.2 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,395.6 ns |    161.12 ns |     8.83 ns |     1,385.7 ns |     1,402.6 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,627.8 ns |    254.05 ns |    13.93 ns |     1,613.9 ns |     1,641.7 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,575.7 ns |    383.09 ns |    21.00 ns |     2,561.0 ns |     2,599.7 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       177.2 ns |     28.92 ns |     1.59 ns |       175.7 ns |       178.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       265.3 ns |    123.33 ns |     6.76 ns |       257.7 ns |       270.5 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       471.9 ns |     34.93 ns |     1.91 ns |       470.5 ns |       474.1 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,890.5 ns** |  **7,963.99 ns** |   **436.53 ns** | **1,553,502.4 ns** | **1,554,363.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,584.9 ns |  2,186.30 ns |   119.84 ns |   617,447.2 ns |   617,665.5 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   658,605.9 ns |  1,878.53 ns |   102.97 ns |   658,541.0 ns |   658,724.6 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,382,836.1 ns | 87,751.97 ns | 4,809.98 ns | 1,379,875.7 ns | 1,388,386.1 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,489.0 ns |  7,266.12 ns |   398.28 ns |   163,063.1 ns |   163,852.3 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,725.9 ns | 13,547.74 ns |   742.60 ns |    92,237.2 ns |    93,580.4 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,029.7 ns |  7,477.55 ns |   409.87 ns |    65,557.4 ns |    66,291.9 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,556.4 ns |  4,265.12 ns |   233.79 ns | 1,553,298.2 ns | 1,553,753.8 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,458.3 ns |  4,872.63 ns |   267.09 ns |   617,219.3 ns |   617,746.6 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   660,091.0 ns | 23,897.13 ns | 1,309.88 ns |   658,587.7 ns |   660,987.6 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,385,941.1 ns | 39,811.75 ns | 2,182.22 ns | 1,383,714.5 ns | 1,388,076.0 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,016.0 ns |    124.19 ns |     6.81 ns |   163,009.3 ns |   163,022.9 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    91,882.7 ns |  1,388.95 ns |    76.13 ns |    91,814.8 ns |    91,965.0 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,158.7 ns |  7,473.16 ns |   409.63 ns |    33,687.9 ns |    34,433.7 ns |      - |      40 B |
