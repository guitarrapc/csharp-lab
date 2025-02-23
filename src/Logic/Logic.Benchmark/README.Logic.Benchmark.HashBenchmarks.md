```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method          | Runtime  | data                | Mean           | Error         | StdDev      | Min            | Max            | Gen0   | Allocated |
|---------------- |--------- |-------------------- |---------------:|--------------:|------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,219.4 ns** |      **31.59 ns** |     **1.73 ns** |     **1,217.6 ns** |     **1,221.1 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,412.0 ns |     135.45 ns |     7.42 ns |     1,407.6 ns |     1,420.6 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,642.0 ns |      36.54 ns |     2.00 ns |     1,640.1 ns |     1,644.1 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,568.6 ns |     159.30 ns |     8.73 ns |     2,560.5 ns |     2,577.9 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       180.7 ns |      12.07 ns |     0.66 ns |       180.3 ns |       181.5 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       270.5 ns |      15.22 ns |     0.83 ns |       269.6 ns |       271.3 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       462.8 ns |      28.53 ns |     1.56 ns |       461.3 ns |       464.5 ns | 0.0672 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,208.9 ns |      11.87 ns |     0.65 ns |     1,208.1 ns |     1,209.4 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,380.6 ns |      52.80 ns |     2.89 ns |     1,378.2 ns |     1,383.9 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,624.6 ns |     233.81 ns |    12.82 ns |     1,610.6 ns |     1,635.8 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,632.6 ns |     248.82 ns |    13.64 ns |     2,622.5 ns |     2,648.1 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       172.0 ns |       3.76 ns |     0.21 ns |       171.8 ns |       172.2 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       252.3 ns |      16.86 ns |     0.92 ns |       251.3 ns |       252.9 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       463.8 ns |      29.40 ns |     1.61 ns |       462.2 ns |       465.4 ns | 0.0672 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,554,202.0 ns** |   **2,457.15 ns** |   **134.68 ns** | **1,554,063.9 ns** | **1,554,333.0 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   617,741.8 ns |   1,750.94 ns |    95.97 ns |   617,661.8 ns |   617,848.2 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   659,475.9 ns |  22,170.29 ns | 1,215.23 ns |   658,689.2 ns |   660,875.6 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,383,711.9 ns |  59,769.49 ns | 3,276.17 ns | 1,380,659.0 ns | 1,387,173.0 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   163,287.5 ns |   1,364.70 ns |    74.80 ns |   163,217.3 ns |   163,366.2 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    92,214.9 ns |   7,168.57 ns |   392.93 ns |    91,943.4 ns |    92,665.5 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,063.7 ns |   7,300.88 ns |   400.19 ns |    65,604.5 ns |    66,338.1 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,554,295.8 ns |   7,969.68 ns |   436.85 ns | 1,554,001.5 ns | 1,554,797.8 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   618,472.0 ns |  14,005.01 ns |   767.66 ns |   617,992.5 ns |   619,357.4 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   658,760.9 ns |   2,618.26 ns |   143.52 ns |   658,595.3 ns |   658,847.3 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,385,615.1 ns | 152,492.19 ns | 8,358.61 ns | 1,379,983.6 ns | 1,395,219.2 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   163,796.6 ns |   9,910.17 ns |   543.21 ns |   163,184.1 ns |   164,220.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    92,105.4 ns |   5,871.14 ns |   321.82 ns |    91,911.3 ns |    92,476.9 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    33,993.8 ns |   5,153.92 ns |   282.50 ns |    33,726.9 ns |    34,289.6 ns |      - |      40 B |
