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
| **MD5String**       | **.NET 8.0** | **KLVJ(...)0t2z [160]** |     **1,331.0 ns** |    **211.54 ns** |    **11.60 ns** |     **1,317.8 ns** |     **1,339.5 ns** | **0.0668** |    **1128 B** |
| SHA1String      | .NET 8.0 | KLVJ(...)0t2z [160] |     1,501.7 ns |    310.43 ns |    17.02 ns |     1,485.2 ns |     1,519.2 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 8.0 | KLVJ(...)0t2z [160] |     1,832.5 ns |    331.29 ns |    18.16 ns |     1,821.3 ns |     1,853.4 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 8.0 | KLVJ(...)0t2z [160] |     2,715.7 ns |    819.28 ns |    44.91 ns |     2,680.5 ns |     2,766.3 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 8.0 | KLVJ(...)0t2z [160] |       265.0 ns |     73.33 ns |     4.02 ns |       262.4 ns |       269.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 8.0 | KLVJ(...)0t2z [160] |       313.3 ns |     43.17 ns |     2.37 ns |       311.0 ns |       315.7 ns | 0.0434 |     728 B |
| XxHash128String | .NET 8.0 | KLVJ(...)0t2z [160] |       529.3 ns |     68.66 ns |     3.76 ns |       525.0 ns |       532.1 ns | 0.0668 |    1128 B |
| MD5String       | .NET 9.0 | KLVJ(...)0t2z [160] |     1,317.8 ns |    137.94 ns |     7.56 ns |     1,309.6 ns |     1,324.6 ns | 0.0668 |    1128 B |
| SHA1String      | .NET 9.0 | KLVJ(...)0t2z [160] |     1,641.5 ns |     56.76 ns |     3.11 ns |     1,638.9 ns |     1,645.0 ns | 0.0839 |    1416 B |
| SHA256String    | .NET 9.0 | KLVJ(...)0t2z [160] |     1,866.2 ns |     73.08 ns |     4.01 ns |     1,861.6 ns |     1,868.6 ns | 0.1106 |    1856 B |
| SHA512String    | .NET 9.0 | KLVJ(...)0t2z [160] |     2,783.8 ns |    179.98 ns |     9.87 ns |     2,774.3 ns |     2,794.0 ns | 0.1907 |    3240 B |
| XxHash32String  | .NET 9.0 | KLVJ(...)0t2z [160] |       213.9 ns |     65.37 ns |     3.58 ns |       210.5 ns |       217.6 ns | 0.0348 |     584 B |
| XxHash64String  | .NET 9.0 | KLVJ(...)0t2z [160] |       310.4 ns |    162.58 ns |     8.91 ns |       300.3 ns |       317.3 ns | 0.0434 |     728 B |
| XxHash128String | .NET 9.0 | KLVJ(...)0t2z [160] |       541.0 ns |     95.15 ns |     5.22 ns |       535.4 ns |       545.7 ns | 0.0668 |    1128 B |
| **MD5Binary**       | **.NET 8.0** | **Byte[1048576]**       | **1,565,320.6 ns** | **69,900.64 ns** | **3,831.49 ns** | **1,560,903.5 ns** | **1,567,746.9 ns** |      **-** |      **41 B** |
| SHA1Binary      | .NET 8.0 | Byte[1048576]       |   618,313.7 ns | 14,721.03 ns |   806.91 ns |   617,807.4 ns |   619,244.3 ns |      - |      49 B |
| SHA256Binary    | .NET 8.0 | Byte[1048576]       |   665,252.9 ns | 73,993.25 ns | 4,055.82 ns |   660,929.3 ns |   668,973.4 ns |      - |      57 B |
| SHA512Binary    | .NET 8.0 | Byte[1048576]       | 1,384,864.0 ns | 71,817.86 ns | 3,936.58 ns | 1,380,928.1 ns | 1,388,801.2 ns |      - |      89 B |
| XxHash32Binary  | .NET 8.0 | Byte[1048576]       |   165,073.5 ns | 17,839.80 ns |   977.86 ns |   163,955.8 ns |   165,771.0 ns |      - |      32 B |
| XxHash64Binary  | .NET 8.0 | Byte[1048576]       |    96,005.0 ns | 32,092.24 ns | 1,759.08 ns |    94,013.7 ns |    97,347.6 ns |      - |      32 B |
| XxHash128Binary | .NET 8.0 | Byte[1048576]       |    66,295.0 ns |  4,554.31 ns |   249.64 ns |    66,007.1 ns |    66,451.4 ns |      - |      40 B |
| MD5Binary       | .NET 9.0 | Byte[1048576]       | 1,556,141.3 ns | 33,114.47 ns | 1,815.12 ns | 1,554,731.0 ns | 1,558,189.2 ns |      - |      41 B |
| SHA1Binary      | .NET 9.0 | Byte[1048576]       |   618,004.7 ns |  2,828.88 ns |   155.06 ns |   617,866.1 ns |   618,172.2 ns |      - |      49 B |
| SHA256Binary    | .NET 9.0 | Byte[1048576]       |   660,110.2 ns | 23,605.96 ns | 1,293.92 ns |   659,259.3 ns |   661,599.2 ns |      - |      57 B |
| SHA512Binary    | .NET 9.0 | Byte[1048576]       | 1,382,621.9 ns |  3,431.05 ns |   188.07 ns | 1,382,417.9 ns | 1,382,788.3 ns |      - |      89 B |
| XxHash32Binary  | .NET 9.0 | Byte[1048576]       |   164,191.7 ns |  7,651.33 ns |   419.40 ns |   163,707.7 ns |   164,449.4 ns |      - |      32 B |
| XxHash64Binary  | .NET 9.0 | Byte[1048576]       |    95,116.8 ns | 25,266.53 ns | 1,384.94 ns |    93,660.7 ns |    96,417.4 ns |      - |      32 B |
| XxHash128Binary | .NET 9.0 | Byte[1048576]       |    34,077.4 ns |  5,885.17 ns |   322.59 ns |    33,814.5 ns |    34,437.4 ns |      - |      40 B |
