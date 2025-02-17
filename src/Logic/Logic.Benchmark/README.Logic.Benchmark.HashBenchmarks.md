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
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,256.8 ns** |    **176.37 ns** |     **9.67 ns** |     **1,250.5 ns** |     **1,267.9 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,429.0 ns |     63.17 ns |     3.46 ns |     1,425.6 ns |     1,432.5 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,700.9 ns |    204.25 ns |    11.20 ns |     1,689.8 ns |     1,712.2 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,656.7 ns |    200.67 ns |    11.00 ns |     2,647.2 ns |     2,668.7 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       196.2 ns |     13.36 ns |     0.73 ns |       195.5 ns |       196.9 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       279.0 ns |     69.83 ns |     3.83 ns |       276.3 ns |       283.4 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       483.2 ns |    136.43 ns |     7.48 ns |       474.6 ns |       488.4 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,335.7 ns |    180.82 ns |     9.91 ns |     1,328.2 ns |     1,346.9 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,421.1 ns |     80.39 ns |     4.41 ns |     1,416.4 ns |     1,425.0 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,772.5 ns |    274.14 ns |    15.03 ns |     1,763.8 ns |     1,789.9 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,622.0 ns |    217.74 ns |    11.94 ns |     2,609.1 ns |     2,632.7 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       182.2 ns |     63.11 ns |     3.46 ns |       178.9 ns |       185.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       258.8 ns |     52.64 ns |     2.89 ns |       255.6 ns |       261.3 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       478.7 ns |    176.55 ns |     9.68 ns |       469.4 ns |       488.7 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,904.6 ns** | **12,798.15 ns** |   **701.51 ns** | **1,553,446.4 ns** | **1,554,712.2 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,641.1 ns |  4,050.58 ns |   222.03 ns |   617,445.3 ns |   617,882.3 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,161.0 ns | 24,335.09 ns | 1,333.89 ns |   658,278.7 ns |   660,695.5 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,383,834.0 ns | 68,100.05 ns | 3,732.79 ns | 1,380,424.8 ns | 1,387,822.6 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,877.7 ns | 21,399.19 ns | 1,172.96 ns |   163,190.8 ns |   165,232.1 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,186.7 ns |  6,053.36 ns |   331.81 ns |    91,965.7 ns |    92,568.2 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,891.0 ns | 11,300.05 ns |   619.39 ns |    65,501.0 ns |    66,605.2 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,553,858.1 ns |  6,325.59 ns |   346.73 ns | 1,553,614.7 ns | 1,554,255.1 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,569.2 ns |  1,626.62 ns |    89.16 ns |   617,471.7 ns |   617,646.6 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   660,331.7 ns | 16,530.16 ns |   906.07 ns |   659,383.8 ns |   661,189.2 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,384,534.4 ns | 84,068.80 ns | 4,608.09 ns | 1,379,315.7 ns | 1,388,042.9 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   165,584.3 ns | 67,957.79 ns | 3,725.00 ns |   163,060.8 ns |   169,862.6 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,223.2 ns |  3,312.02 ns |   181.54 ns |    92,029.3 ns |    92,389.1 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,817.7 ns |  3,518.63 ns |   192.87 ns |    33,668.9 ns |    34,035.6 ns |      - |      40 B |
