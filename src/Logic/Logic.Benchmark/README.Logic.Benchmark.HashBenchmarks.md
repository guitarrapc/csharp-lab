```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error        | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|-------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,235.5 ns** |    **110.36 ns** |     **6.05 ns** |     **1,229.7 ns** |     **1,241.8 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,402.5 ns |     64.47 ns |     3.53 ns |     1,400.2 ns |     1,406.6 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,646.1 ns |     34.26 ns |     1.88 ns |     1,644.2 ns |     1,647.9 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,576.1 ns |    308.86 ns |    16.93 ns |     2,562.4 ns |     2,595.0 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       183.1 ns |     11.79 ns |     0.65 ns |       182.6 ns |       183.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       264.9 ns |     14.86 ns |     0.81 ns |       264.1 ns |       265.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       485.1 ns |     45.43 ns |     2.49 ns |       483.0 ns |       487.8 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,214.7 ns |     88.88 ns |     4.87 ns |     1,210.0 ns |     1,219.7 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,398.4 ns |    293.58 ns |    16.09 ns |     1,385.4 ns |     1,416.4 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,630.3 ns |    108.34 ns |     5.94 ns |     1,623.7 ns |     1,635.2 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,559.3 ns |    294.88 ns |    16.16 ns |     2,542.6 ns |     2,574.9 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       181.7 ns |     39.36 ns |     2.16 ns |       179.5 ns |       183.8 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       251.9 ns |     17.65 ns |     0.97 ns |       250.9 ns |       252.8 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       467.1 ns |    132.65 ns |     7.27 ns |       461.5 ns |       475.3 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,553,709.2 ns** | **12,350.32 ns** |   **676.96 ns** | **1,553,036.8 ns** | **1,554,390.7 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,707.4 ns |  3,377.98 ns |   185.16 ns |   617,493.7 ns |   617,819.3 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,965.0 ns | 14,310.05 ns |   784.38 ns |   659,066.6 ns |   660,513.8 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,382,664.4 ns | 60,100.15 ns | 3,294.29 ns | 1,380,692.0 ns | 1,386,467.5 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,510.7 ns | 10,323.39 ns |   565.86 ns |   163,087.7 ns |   164,153.5 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,568.5 ns | 12,181.94 ns |   667.73 ns |    91,985.5 ns |    93,297.0 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    65,620.3 ns |  1,112.41 ns |    60.97 ns |    65,576.4 ns |    65,689.9 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,554,201.2 ns |  1,190.27 ns |    65.24 ns | 1,554,132.7 ns | 1,554,262.6 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   617,675.1 ns |  3,714.98 ns |   203.63 ns |   617,481.1 ns |   617,887.2 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   658,776.9 ns |  7,526.35 ns |   412.54 ns |   658,322.7 ns |   659,128.3 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,381,002.7 ns | 27,546.22 ns | 1,509.90 ns | 1,379,341.0 ns | 1,382,290.5 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,461.1 ns | 12,284.35 ns |   673.35 ns |   163,053.1 ns |   164,238.3 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,300.7 ns |  7,461.17 ns |   408.97 ns |    91,828.5 ns |    92,541.4 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,918.8 ns |  2,622.44 ns |   143.75 ns |    33,815.9 ns |    34,083.0 ns |      - |      40 B |
